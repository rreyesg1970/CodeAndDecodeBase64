// Programa hecho por Roberto Reyes García el 21-03-2020
// para codificar y decodificar archivos en Base64

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Code_and_Decode_base64
{
    public partial class FrmPrincipal : Form
    {
        #region Campos
        private string ruta;
        private string textoCodificado;
        private string textoNormal;
        private string textoDecodificado;
        StreamReader flujoEntrada;

        string textoCodificadoTemp;
        string textoDecodificadoTemp;


        #endregion Campos


        #region Constructor
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion Constructor


        #region Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BtnDecodificarArchivo.Enabled = false;
            BtnCodificarArchivo.Enabled = false;
            //
        }

        private void BtnAbrirArchivoCodificado_Click(object sender, EventArgs e)
        {
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                BtnDecodificarArchivo.Enabled = true;
                BtnCodificarArchivo.Enabled = false;
                LblDragAndDrop.Visible = false;
                ruta = Ofd1.FileName;
                TxtRuta.Text = ruta;

                flujoEntrada = new StreamReader(ruta);
                textoCodificado = flujoEntrada.ReadToEnd();
                TxtArchivoLeido.Text = textoCodificado;
            }
        }

        private void TxtArchivoLeido_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TxtArchivoLeido_DragEnter(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            TxtRuta.Text = archivos[0];
            var archivo = TxtRuta.Text;
            FileInfo file = new FileInfo(archivo);

            flujoEntrada = new StreamReader(archivos[0]);
            textoCodificado = flujoEntrada.ReadToEnd();
            TxtArchivoLeido.Text = textoCodificado;

            if (file.Extension != ".XML")
            {
                MessageBox.Show("El archivo seleccionado no es un documento XML", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BtnDecodificarArchivo.Enabled = true;
                BtnCodificarArchivo.Enabled = false;
                LblDragAndDrop.Visible = false;
            }
        }

        private void BtnAbrirArchivoNormal_Click(object sender, EventArgs e)
        {
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BtnDecodificarArchivo.Enabled = false;
                    BtnCodificarArchivo.Enabled = true;
                    ruta = Ofd1.FileName;
                    TxtRuta.Text = ruta;

                    flujoEntrada = new StreamReader(ruta);
                    textoNormal = flujoEntrada.ReadToEnd();

                    string parsedXml = string.Empty;
                    parsedXml = textoNormal;
                    TxtArchivoLeido.Text = System.Xml.Linq.XDocument.Parse(parsedXml).ToString();
                }
                catch (XmlException ex)
                {
                    MessageBox.Show("El archivo leído no es un XML válido", "Error de lectura",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecodificararchivo_Click(object sender, EventArgs e)
        {
            try
            {
                string parsedXml = string.Empty;
                parsedXml = Decodificar(textoCodificado);
                TxtArchivoConvertido.Text = System.Xml.Linq.XDocument.Parse(parsedXml).ToString();
            }
            catch (XmlException ex)
            {
                MessageBox.Show("El archivo leído no se pudo convertir a XML", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TxtArchivoConvertido_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void TxtArchivoConvertido_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void BtnCodificar_Click(object sender, EventArgs e)
        {
            TxtArchivoConvertido.Text = Codificar(textoNormal);
        }

        private void BtnLimpiarVentanas_Click_1(object sender, EventArgs e)
        {
            textoCodificado = string.Empty;
            textoDecodificado = string.Empty;
            TxtArchivoConvertido.Clear();
            TxtArchivoLeido.Clear();
            TxtRuta.Clear();
            LblDragAndDrop.Visible = true;
        }

        private void BtnGuardarArchivoDecodificado_Click(object sender, EventArgs e)
        {
            GuardarArchivoDecodificado();
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
           CambioTamañoTextBox(sender);
        }
        #endregion Eventos


        #region Metodos
        public static string Decodificar(string textoCodif)
        {
            //Decodificamos en base64
            try
            {
                byte[] decbuff = Convert.FromBase64String(textoCodif);
                return System.Text.Encoding.UTF8.GetString(decbuff);
            }
            catch
            {
                //si se envia una cadena si codificación base64, mandamos vacio
                return "";
            }
        }

        public static string Codificar(string textoDecodif)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(textoDecodif);
            return Convert.ToBase64String(encbuff);
        }
        #endregion Metodos
        private void GuardarArchivoDecodificado()
        {
            //Stream myStream;
            string nombreArchivoFinal = string.Empty;
            SaveFileDialog Sfd1 = new SaveFileDialog();

            Sfd1.InitialDirectory = Directory.GetCurrentDirectory();
            Sfd1.Title = "Guardar archivo";
            Sfd1.CheckPathExists = true;
            Sfd1.RestoreDirectory = true;
            Sfd1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            Sfd1.FilterIndex = 1;
            Sfd1.DefaultExt = "xml";

            if (Sfd1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoFinal = Sfd1.FileName;
                StreamWriter sw = File.CreateText(nombreArchivoFinal);

                sw.Write(TxtArchivoConvertido.Text);
                sw.Close();

                LblArchivoGuardadoOK.Text = "Archivo guardado OK";

            }
        }

        private void CambioTamañoTextBox(object sender)
        {
            int diferenciaAncho = 33;
            int diferenciaAlto = 205;
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Height);

                TxtArchivoLeido.Size = new Size((control.Size.Width / 2) - diferenciaAncho,
                                            control.Size.Height - diferenciaAlto);

                LblArchivoConvertido.Location = new Point(((control.Size.Width / 2) + diferenciaAncho - 34), 46);
                TxtArchivoConvertido.Location = new Point(((control.Size.Width / 2) + diferenciaAncho - 34), 62);
                BtnAbrirArchivoNormal.Location = new Point(((control.Size.Width / 2) + diferenciaAncho - 34), control.Size.Height - 135);
                BtnGuardarArchivoDecodificado.Location = new Point(((control.Size.Width / 2) + diferenciaAncho - 34), control.Size.Height - 105);
                LblArchivoGuardadoOK.Location = new Point(((control.Size.Width / 2) + diferenciaAncho + 145), control.Size.Height - 134);
                BtnCodificarArchivo.Location = new Point(((control.Size.Width / 2) + diferenciaAncho + 187), control.Size.Height - 135);

                TxtArchivoConvertido.Size = new Size((control.Size.Width / 2) - diferenciaAncho,
                                           control.Size.Height - diferenciaAlto);
            }
        }

        private void FrmPrincipal_ResizeBegin(object sender, EventArgs e)
        {
            textoCodificadoTemp = TxtArchivoLeido.Text;
            textoDecodificadoTemp = TxtArchivoConvertido.Text;
            TxtArchivoLeido.Text = string.Empty;
            TxtArchivoConvertido.Text = string.Empty;
        }

        private void FrmPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            TxtArchivoLeido.Text = textoCodificadoTemp;
            TxtArchivoConvertido.Text = textoDecodificadoTemp;
        }

       
    }
}
