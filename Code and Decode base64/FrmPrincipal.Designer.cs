namespace Code_and_Decode_base64
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnCodificarArchivo = new System.Windows.Forms.Button();
            this.BtnDecodificararchivo = new System.Windows.Forms.Button();
            this.TxtArchivoLeido = new System.Windows.Forms.TextBox();
            this.TxtArchivoConvertido = new System.Windows.Forms.TextBox();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrirArchivoCodificado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiarVentanas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAbrirArchivoNormal = new System.Windows.Forms.Button();
            this.BtnGuardarArchivoDecodificado = new System.Windows.Forms.Button();
            this.Sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BtnCodificarArchivo
            // 
            this.BtnCodificarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCodificarArchivo.Location = new System.Drawing.Point(672, 440);
            this.BtnCodificarArchivo.Name = "BtnCodificarArchivo";
            this.BtnCodificarArchivo.Size = new System.Drawing.Size(116, 23);
            this.BtnCodificarArchivo.TabIndex = 0;
            this.BtnCodificarArchivo.Text = "Codificar";
            this.BtnCodificarArchivo.UseVisualStyleBackColor = true;
            this.BtnCodificarArchivo.Click += new System.EventHandler(this.BtnCodificar_Click);
            // 
            // BtnDecodificararchivo
            // 
            this.BtnDecodificararchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDecodificararchivo.Location = new System.Drawing.Point(280, 440);
            this.BtnDecodificararchivo.Name = "BtnDecodificararchivo";
            this.BtnDecodificararchivo.Size = new System.Drawing.Size(116, 23);
            this.BtnDecodificararchivo.TabIndex = 1;
            this.BtnDecodificararchivo.Text = "Decodificar";
            this.BtnDecodificararchivo.UseVisualStyleBackColor = true;
            this.BtnDecodificararchivo.Click += new System.EventHandler(this.BtnDecodificar_Click);
            // 
            // TxtArchivoLeido
            // 
            this.TxtArchivoLeido.AllowDrop = true;
            this.TxtArchivoLeido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtArchivoLeido.Location = new System.Drawing.Point(13, 58);
            this.TxtArchivoLeido.Multiline = true;
            this.TxtArchivoLeido.Name = "TxtArchivoLeido";
            this.TxtArchivoLeido.ReadOnly = true;
            this.TxtArchivoLeido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtArchivoLeido.Size = new System.Drawing.Size(383, 376);
            this.TxtArchivoLeido.TabIndex = 2;
            // 
            // TxtArchivoConvertido
            // 
            this.TxtArchivoConvertido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtArchivoConvertido.Location = new System.Drawing.Point(405, 58);
            this.TxtArchivoConvertido.Multiline = true;
            this.TxtArchivoConvertido.Name = "TxtArchivoConvertido";
            this.TxtArchivoConvertido.ReadOnly = true;
            this.TxtArchivoConvertido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtArchivoConvertido.Size = new System.Drawing.Size(383, 376);
            this.TxtArchivoConvertido.TabIndex = 3;
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "archivo";
            // 
            // BtnAbrirArchivoCodificado
            // 
            this.BtnAbrirArchivoCodificado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbrirArchivoCodificado.Location = new System.Drawing.Point(13, 440);
            this.BtnAbrirArchivoCodificado.Name = "BtnAbrirArchivoCodificado";
            this.BtnAbrirArchivoCodificado.Size = new System.Drawing.Size(167, 23);
            this.BtnAbrirArchivoCodificado.TabIndex = 4;
            this.BtnAbrirArchivoCodificado.Text = "Leer Archivo XML Codificado";
            this.BtnAbrirArchivoCodificado.UseVisualStyleBackColor = true;
            this.BtnAbrirArchivoCodificado.Click += new System.EventHandler(this.BtnAbrirArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Archivo leído";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Archivo convertido";
            // 
            // BtnLimpiarVentanas
            // 
            this.BtnLimpiarVentanas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLimpiarVentanas.Location = new System.Drawing.Point(13, 469);
            this.BtnLimpiarVentanas.Name = "BtnLimpiarVentanas";
            this.BtnLimpiarVentanas.Size = new System.Drawing.Size(167, 23);
            this.BtnLimpiarVentanas.TabIndex = 9;
            this.BtnLimpiarVentanas.Text = "Limpia Ventanas";
            this.BtnLimpiarVentanas.UseVisualStyleBackColor = true;
            this.BtnLimpiarVentanas.Click += new System.EventHandler(this.BtnLimpiarVentanas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hecho por Roberto Reyes García, 21 Marzo - 9 Septiembre - 2020";
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(58, 9);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(730, 20);
            this.TxtRuta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ruta";
            // 
            // BtnAbrirArchivoNormal
            // 
            this.BtnAbrirArchivoNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbrirArchivoNormal.Location = new System.Drawing.Point(405, 440);
            this.BtnAbrirArchivoNormal.Name = "BtnAbrirArchivoNormal";
            this.BtnAbrirArchivoNormal.Size = new System.Drawing.Size(160, 23);
            this.BtnAbrirArchivoNormal.TabIndex = 13;
            this.BtnAbrirArchivoNormal.Text = "Leer Archivo XML  normal";
            this.BtnAbrirArchivoNormal.UseVisualStyleBackColor = true;
            this.BtnAbrirArchivoNormal.Click += new System.EventHandler(this.BtnAbrirArchivoNormal_Click);
            // 
            // BtnGuardarArchivoDecodificado
            // 
            this.BtnGuardarArchivoDecodificado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardarArchivoDecodificado.Location = new System.Drawing.Point(405, 469);
            this.BtnGuardarArchivoDecodificado.Name = "BtnGuardarArchivoDecodificado";
            this.BtnGuardarArchivoDecodificado.Size = new System.Drawing.Size(160, 23);
            this.BtnGuardarArchivoDecodificado.TabIndex = 14;
            this.BtnGuardarArchivoDecodificado.Text = "Guardar Archivo Decodificado";
            this.BtnGuardarArchivoDecodificado.UseVisualStyleBackColor = true;
            this.BtnGuardarArchivoDecodificado.Click += new System.EventHandler(this.BtnGuardarArchivoDecodificado_Click);
            // 
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.BtnGuardarArchivoDecodificado);
            this.Controls.Add(this.BtnAbrirArchivoNormal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLimpiarVentanas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAbrirArchivoCodificado);
            this.Controls.Add(this.TxtArchivoConvertido);
            this.Controls.Add(this.TxtArchivoLeido);
            this.Controls.Add(this.BtnDecodificararchivo);
            this.Controls.Add(this.BtnCodificarArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Decodificar y Codificar Base64";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCodificarArchivo;
        private System.Windows.Forms.Button BtnDecodificararchivo;
        private System.Windows.Forms.TextBox TxtArchivoLeido;
        private System.Windows.Forms.TextBox TxtArchivoConvertido;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.Button BtnAbrirArchivoCodificado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiarVentanas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAbrirArchivoNormal;
        private System.Windows.Forms.Button BtnGuardarArchivoDecodificado;
        private System.Windows.Forms.SaveFileDialog Sfd1;
    }
}

