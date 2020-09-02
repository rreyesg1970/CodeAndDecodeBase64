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
            BtnDecodificararchivo.Enabled = false;
            BtnCodificarArchivo.Enabled = false;
            //
        }

        private void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                BtnDecodificararchivo.Enabled = true;
                BtnCodificarArchivo.Enabled = false;
                ruta = Ofd1.FileName;
                TxtRuta.Text = ruta;

                flujoEntrada = new StreamReader(ruta);
                textoCodificado = flujoEntrada.ReadToEnd();
                TxtArchivoLeido.Text = textoCodificado;
            }
        }

        private void BtnAbrirArchivoNormal_Click(object sender, EventArgs e)
        {
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                BtnDecodificararchivo.Enabled = false;
                BtnCodificarArchivo.Enabled = true;
                ruta = Ofd1.FileName;
                TxtRuta.Text = ruta;

                flujoEntrada = new StreamReader(ruta);
                textoNormal = flujoEntrada.ReadToEnd();
                TxtArchivoLeido.Text = textoNormal;
            }
        }

        private void BtnDecodificar_Click(object sender, EventArgs e)
        {
            TxtArchivoConvertido.Text = Decodificar(textoCodificado);
        }

        private void BtnCodificar_Click(object sender, EventArgs e)
        {
            TxtArchivoConvertido.Text = Codificar(textoNormal);
        }

        private void BtnLimpiarVentanas_Click(object sender, EventArgs e)
        {
            textoCodificado = string.Empty;
            textoDecodificado = string.Empty;
            TxtArchivoConvertido.Clear();
            TxtArchivoLeido.Clear();
            TxtRuta.Clear();
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
    }
}
