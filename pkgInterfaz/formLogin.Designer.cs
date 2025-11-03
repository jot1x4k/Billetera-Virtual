namespace testForms
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.lblEntrar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.picMostrarClave = new System.Windows.Forms.PictureBox();
            this.picOcultarClave = new System.Windows.Forms.PictureBox();
            this.pBoton2 = new testForms.pkgInterfaz.pBoton();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.lblNoRegistrado = new System.Windows.Forms.Label();
            this.bntRegistrarse = new testForms.pkgInterfaz.pBoton();
            this.btnIniciarSesion = new testForms.pkgInterfaz.pBoton();
            this.txtClave = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.pLineaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).BeginInit();
            this.pDegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrar
            // 
            this.lblEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(305, 211);
            this.lblEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(190, 67);
            this.lblEntrar.TabIndex = 0;
            this.lblEntrar.Text = "Entrar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(316, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.CausesValidation = false;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorUsuario.Location = new System.Drawing.Point(248, 344);
            this.lblErrorUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(173, 17);
            this.lblErrorUsuario.TabIndex = 24;
            this.lblErrorUsuario.Text = "Ingrese un usuario valido";
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.CausesValidation = false;
            this.lblErrorClave.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorClave.Location = new System.Drawing.Point(248, 424);
            this.lblErrorClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(212, 17);
            this.lblErrorClave.TabIndex = 25;
            this.lblErrorClave.Text = "Ingrese una contraseña valida";
            // 
            // picMostrarClave
            // 
            this.picMostrarClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClave.Image")));
            this.picMostrarClave.Location = new System.Drawing.Point(568, 392);
            this.picMostrarClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMostrarClave.Name = "picMostrarClave";
            this.picMostrarClave.Size = new System.Drawing.Size(36, 28);
            this.picMostrarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClave.TabIndex = 28;
            this.picMostrarClave.TabStop = false;
            this.picMostrarClave.Click += new System.EventHandler(this.picMostrarClave_Click);
            // 
            // picOcultarClave
            // 
            this.picOcultarClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picOcultarClave.Enabled = false;
            this.picOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClave.Image")));
            this.picOcultarClave.Location = new System.Drawing.Point(568, 392);
            this.picOcultarClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOcultarClave.Name = "picOcultarClave";
            this.picOcultarClave.Size = new System.Drawing.Size(36, 28);
            this.picOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClave.TabIndex = 29;
            this.picOcultarClave.TabStop = false;
            this.picOcultarClave.Visible = false;
            this.picOcultarClave.Click += new System.EventHandler(this.picOcultarClave_Click);
            // 
            // pBoton2
            // 
            this.pBoton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoton2.BackColor = System.Drawing.Color.DimGray;
            this.pBoton2.BackgroundColor = System.Drawing.Color.DimGray;
            this.pBoton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pBoton2.BorderRadius = 5;
            this.pBoton2.BorderSize = 0;
            this.pBoton2.FlatAppearance.BorderSize = 0;
            this.pBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton2.Font = new System.Drawing.Font("Codec Pro Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton2.ForeColor = System.Drawing.Color.White;
            this.pBoton2.Location = new System.Drawing.Point(720, 8);
            this.pBoton2.Name = "pBoton2";
            this.pBoton2.Size = new System.Drawing.Size(38, 24);
            this.pBoton2.TabIndex = 50;
            this.pBoton2.Text = "-";
            this.pBoton2.TextColor = System.Drawing.Color.White;
            this.pBoton2.UseVisualStyleBackColor = false;
            this.pBoton2.Click += new System.EventHandler(this.pBoton2_Click);
            // 
            // pBoton1
            // 
            this.pBoton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BorderColor = System.Drawing.Color.White;
            this.pBoton1.BorderRadius = 5;
            this.pBoton1.BorderSize = 0;
            this.pBoton1.FlatAppearance.BorderSize = 0;
            this.pBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton1.Font = new System.Drawing.Font("Codec Pro Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton1.ForeColor = System.Drawing.Color.White;
            this.pBoton1.Location = new System.Drawing.Point(760, 8);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(38, 24);
            this.pBoton1.TabIndex = 49;
            this.pBoton1.Text = "X";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click);
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 90F;
            this.pDegradado1.Controls.Add(this.lblNoRegistrado);
            this.pDegradado1.Controls.Add(this.bntRegistrarse);
            this.pDegradado1.Controls.Add(this.btnIniciarSesion);
            this.pDegradado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDegradado1.HexColor1 = "#E6E6E6";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 520);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(800, 180);
            this.pDegradado1.TabIndex = 48;
            // 
            // lblNoRegistrado
            // 
            this.lblNoRegistrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoRegistrado.AutoSize = true;
            this.lblNoRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRegistrado.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoRegistrado.ForeColor = System.Drawing.Color.Black;
            this.lblNoRegistrado.Location = new System.Drawing.Point(321, 64);
            this.lblNoRegistrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoRegistrado.Name = "lblNoRegistrado";
            this.lblNoRegistrado.Size = new System.Drawing.Size(159, 20);
            this.lblNoRegistrado.TabIndex = 3;
            this.lblNoRegistrado.Text = "No esta registrado?";
            // 
            // bntRegistrarse
            // 
            this.bntRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntRegistrarse.AutoSize = true;
            this.bntRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(146)))), ((int)(((byte)(36)))));
            this.bntRegistrarse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(146)))), ((int)(((byte)(36)))));
            this.bntRegistrarse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bntRegistrarse.BorderRadius = 8;
            this.bntRegistrarse.BorderSize = 0;
            this.bntRegistrarse.FlatAppearance.BorderSize = 0;
            this.bntRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRegistrarse.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRegistrarse.ForeColor = System.Drawing.Color.White;
            this.bntRegistrarse.Location = new System.Drawing.Point(348, 96);
            this.bntRegistrarse.Name = "bntRegistrarse";
            this.bntRegistrarse.Size = new System.Drawing.Size(106, 37);
            this.bntRegistrarse.TabIndex = 43;
            this.bntRegistrarse.Text = "Registrarse";
            this.bntRegistrarse.TextColor = System.Drawing.Color.White;
            this.bntRegistrarse.UseVisualStyleBackColor = false;
            this.bntRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIniciarSesion.BorderRadius = 8;
            this.btnIniciarSesion.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(324, 10);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(151, 49);
            this.btnIniciarSesion.TabIndex = 42;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClave.esClave = true;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.label = "Contraseña";
            this.txtClave.limiteCaracteres = 50;
            this.txtClave.Location = new System.Drawing.Point(244, 368);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClave.placeholder = " ";
            this.txtClave.Radius = 8;
            this.txtClave.Size = new System.Drawing.Size(313, 55);
            this.txtClave.TabIndex = 39;
            this.txtClave.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.esClave = false;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.label = "Usuario";
            this.txtUsuario.limiteCaracteres = 50;
            this.txtUsuario.Location = new System.Drawing.Point(244, 288);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsuario.placeholder = " ";
            this.txtUsuario.Radius = 8;
            this.txtUsuario.Size = new System.Drawing.Size(313, 55);
            this.txtUsuario.TabIndex = 38;
            this.txtUsuario.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pBoton2);
            this.Controls.Add(this.pBoton1);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picOcultarClave);
            this.Controls.Add(this.picMostrarClave);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEntrar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).EndInit();
            this.pDegradado1.ResumeLayout(false);
            this.pDegradado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label lblNoRegistrado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.PictureBox picMostrarClave;
        private System.Windows.Forms.PictureBox picOcultarClave;
        private pkgInterfaz.pLineaTextBox txtClave;
        private pkgInterfaz.pLineaTextBox txtUsuario;
        private pkgInterfaz.pBoton btnIniciarSesion;
        private pkgInterfaz.pBoton bntRegistrarse;
        private pkgInterfaz.pDegradado pDegradado1;
        private pkgInterfaz.pBoton pBoton1;
        private pkgInterfaz.pBoton pBoton2;
    }
}

