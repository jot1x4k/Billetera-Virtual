namespace testForms.pkgInterfaz
{
    partial class formActualizarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formActualizarCliente));
            this.picOcultarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveNueva = new System.Windows.Forms.PictureBox();
            this.picOcultarClaveNueva = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new testForms.pkgInterfaz.pBoton();
            this.pDegradado3 = new testForms.pkgInterfaz.pDegradado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClaveNueva = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtClaveActual = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtCorreo = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.pLineaTextBox();
            this.lblUsuarioInvalido = new System.Windows.Forms.Label();
            this.lblCorreoInvalido = new System.Windows.Forms.Label();
            this.lblClaveInvalida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMax = new testForms.pkgInterfaz.pBoton();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.pBoton2 = new testForms.pkgInterfaz.pBoton();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveNueva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveNueva)).BeginInit();
            this.pDegradado3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOcultarClaveActual
            // 
            this.picOcultarClaveActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picOcultarClaveActual.Enabled = false;
            this.picOcultarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveActual.Image")));
            this.picOcultarClaveActual.Location = new System.Drawing.Point(1125, 512);
            this.picOcultarClaveActual.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClaveActual.Name = "picOcultarClaveActual";
            this.picOcultarClaveActual.Size = new System.Drawing.Size(32, 28);
            this.picOcultarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveActual.TabIndex = 36;
            this.picOcultarClaveActual.TabStop = false;
            this.picOcultarClaveActual.Visible = false;
            this.picOcultarClaveActual.Click += new System.EventHandler(this.picOcultarClaveActual_Click);
            // 
            // picMostrarClaveActual
            // 
            this.picMostrarClaveActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picMostrarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveActual.Image")));
            this.picMostrarClaveActual.Location = new System.Drawing.Point(1125, 512);
            this.picMostrarClaveActual.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClaveActual.Name = "picMostrarClaveActual";
            this.picMostrarClaveActual.Size = new System.Drawing.Size(32, 28);
            this.picMostrarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveActual.TabIndex = 37;
            this.picMostrarClaveActual.TabStop = false;
            this.picMostrarClaveActual.Click += new System.EventHandler(this.picMostrarClaveActual_Click);
            // 
            // picMostrarClaveNueva
            // 
            this.picMostrarClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picMostrarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveNueva.Image")));
            this.picMostrarClaveNueva.Location = new System.Drawing.Point(1125, 592);
            this.picMostrarClaveNueva.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClaveNueva.Name = "picMostrarClaveNueva";
            this.picMostrarClaveNueva.Size = new System.Drawing.Size(32, 28);
            this.picMostrarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveNueva.TabIndex = 39;
            this.picMostrarClaveNueva.TabStop = false;
            this.picMostrarClaveNueva.Click += new System.EventHandler(this.picMostrarClaveNueva_Click);
            // 
            // picOcultarClaveNueva
            // 
            this.picOcultarClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picOcultarClaveNueva.Enabled = false;
            this.picOcultarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveNueva.Image")));
            this.picOcultarClaveNueva.Location = new System.Drawing.Point(1125, 592);
            this.picOcultarClaveNueva.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClaveNueva.Name = "picOcultarClaveNueva";
            this.picOcultarClaveNueva.Size = new System.Drawing.Size(32, 28);
            this.picOcultarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveNueva.TabIndex = 38;
            this.picOcultarClaveNueva.TabStop = false;
            this.picOcultarClaveNueva.Visible = false;
            this.picOcultarClaveNueva.Click += new System.EventHandler(this.picOcultarClaveNueva_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 88);
            this.label1.TabIndex = 55;
            this.label1.Text = "Modifica los campos que quieras cambiar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 144);
            this.label2.TabIndex = 60;
            this.label2.Text = "Si deseas modificar tu contraseña, primero deberas ingresar tu contraseña actual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Empty;
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.BorderSize = 2;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(873, 664);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 56);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pDegradado3
            // 
            this.pDegradado3.Angle = 90F;
            this.pDegradado3.BackColor = System.Drawing.Color.Transparent;
            this.pDegradado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pDegradado3.Controls.Add(this.btnMax);
            this.pDegradado3.Controls.Add(this.pBoton1);
            this.pDegradado3.Controls.Add(this.pBoton2);
            this.pDegradado3.Controls.Add(this.label4);
            this.pDegradado3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado3.HexColor1 = "#4450c9";
            this.pDegradado3.HexColor2 = "#5C69F5";
            this.pDegradado3.Location = new System.Drawing.Point(0, 0);
            this.pDegradado3.Margin = new System.Windows.Forms.Padding(0);
            this.pDegradado3.Name = "pDegradado3";
            this.pDegradado3.Size = new System.Drawing.Size(1366, 216);
            this.pDegradado3.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(747, 77);
            this.label4.TabIndex = 54;
            this.label4.Text = "Actualizacion de datos";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClaveNueva.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClaveNueva.esClave = false;
            this.txtClaveNueva.label = "Nueva contraseña";
            this.txtClaveNueva.limiteCaracteres = 0;
            this.txtClaveNueva.Location = new System.Drawing.Point(781, 568);
            this.txtClaveNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClaveNueva.placeholder = "Puede contener numeros o @, #";
            this.txtClaveNueva.Radius = 8;
            this.txtClaveNueva.Size = new System.Drawing.Size(339, 55);
            this.txtClaveNueva.TabIndex = 43;
            this.txtClaveNueva.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClaveActual.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClaveActual.esClave = false;
            this.txtClaveActual.label = "Contraseña actual";
            this.txtClaveActual.limiteCaracteres = 50;
            this.txtClaveActual.Location = new System.Drawing.Point(781, 488);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClaveActual.placeholder = "Confirmar contraseña";
            this.txtClaveActual.Radius = 8;
            this.txtClaveActual.Size = new System.Drawing.Size(339, 55);
            this.txtClaveActual.TabIndex = 42;
            this.txtClaveActual.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCorreo.esClave = false;
            this.txtCorreo.label = "Tu correo electronico";
            this.txtCorreo.limiteCaracteres = 254;
            this.txtCorreo.Location = new System.Drawing.Point(781, 402);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtCorreo.placeholder = "Correo electronico";
            this.txtCorreo.Radius = 8;
            this.txtCorreo.Size = new System.Drawing.Size(339, 55);
            this.txtCorreo.TabIndex = 41;
            this.txtCorreo.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.esClave = false;
            this.txtUsuario.label = "Tu usuario de ingreso";
            this.txtUsuario.limiteCaracteres = 50;
            this.txtUsuario.Location = new System.Drawing.Point(781, 320);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsuario.placeholder = "Usuario";
            this.txtUsuario.Radius = 8;
            this.txtUsuario.Size = new System.Drawing.Size(339, 55);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // lblUsuarioInvalido
            // 
            this.lblUsuarioInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuarioInvalido.CausesValidation = false;
            this.lblUsuarioInvalido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioInvalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuarioInvalido.Location = new System.Drawing.Point(787, 376);
            this.lblUsuarioInvalido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioInvalido.Name = "lblUsuarioInvalido";
            this.lblUsuarioInvalido.Size = new System.Drawing.Size(327, 23);
            this.lblUsuarioInvalido.TabIndex = 61;
            this.lblUsuarioInvalido.Text = "El usuario debe tener una longitud minima de 4 caracteres";
            this.lblUsuarioInvalido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUsuarioInvalido.Visible = false;
            // 
            // lblCorreoInvalido
            // 
            this.lblCorreoInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreoInvalido.CausesValidation = false;
            this.lblCorreoInvalido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoInvalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreoInvalido.Location = new System.Drawing.Point(786, 456);
            this.lblCorreoInvalido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoInvalido.Name = "lblCorreoInvalido";
            this.lblCorreoInvalido.Size = new System.Drawing.Size(328, 23);
            this.lblCorreoInvalido.TabIndex = 62;
            this.lblCorreoInvalido.Text = "Debes ingresar una direccion de correo valida";
            this.lblCorreoInvalido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCorreoInvalido.Visible = false;
            // 
            // lblClaveInvalida
            // 
            this.lblClaveInvalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaveInvalida.CausesValidation = false;
            this.lblClaveInvalida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClaveInvalida.Location = new System.Drawing.Point(774, 624);
            this.lblClaveInvalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveInvalida.Name = "lblClaveInvalida";
            this.lblClaveInvalida.Size = new System.Drawing.Size(352, 32);
            this.lblClaveInvalida.TabIndex = 63;
            this.lblClaveInvalida.Text = "La contraseña debe tener una longitud minima de 6 caracteres y no puede ser igual" +
    " a tu clave actual";
            this.lblClaveInvalida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClaveInvalida.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 72);
            this.label3.TabIndex = 64;
            this.label3.Text = "Debes confirmar tu contraseña para poder realizar la actualizacion de tus datos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(117)))));
            this.btnMax.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(117)))));
            this.btnMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.btnMax.BorderRadius = 5;
            this.btnMax.BorderSize = 0;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1200, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(38, 24);
            this.btnMax.TabIndex = 69;
            this.btnMax.Text = "[]";
            this.btnMax.TextColor = System.Drawing.Color.White;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // pBoton1
            // 
            this.pBoton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.pBoton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.pBoton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.pBoton1.BorderRadius = 8;
            this.pBoton1.BorderSize = 2;
            this.pBoton1.FlatAppearance.BorderSize = 0;
            this.pBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton1.ForeColor = System.Drawing.Color.White;
            this.pBoton1.Location = new System.Drawing.Point(1248, 8);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(104, 32);
            this.pBoton1.TabIndex = 68;
            this.pBoton1.Text = "Ir al menu";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click);
            // 
            // pBoton2
            // 
            this.pBoton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(117)))));
            this.pBoton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(117)))));
            this.pBoton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pBoton2.BorderRadius = 5;
            this.pBoton2.BorderSize = 0;
            this.pBoton2.FlatAppearance.BorderSize = 0;
            this.pBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton2.ForeColor = System.Drawing.Color.White;
            this.pBoton2.Location = new System.Drawing.Point(1152, 12);
            this.pBoton2.Name = "pBoton2";
            this.pBoton2.Size = new System.Drawing.Size(38, 24);
            this.pBoton2.TabIndex = 67;
            this.pBoton2.Text = "-";
            this.pBoton2.TextColor = System.Drawing.Color.White;
            this.pBoton2.UseVisualStyleBackColor = false;
            this.pBoton2.Click += new System.EventHandler(this.pBoton2_Click);
            // 
            // formActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1366, 875);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClaveInvalida);
            this.Controls.Add(this.lblCorreoInvalido);
            this.Controls.Add(this.lblUsuarioInvalido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pDegradado3);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picMostrarClaveNueva);
            this.Controls.Add(this.picOcultarClaveNueva);
            this.Controls.Add(this.picMostrarClaveActual);
            this.Controls.Add(this.picOcultarClaveActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formActualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveNueva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveNueva)).EndInit();
            this.pDegradado3.ResumeLayout(false);
            this.pDegradado3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picOcultarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveNueva;
        private System.Windows.Forms.PictureBox picOcultarClaveNueva;
        private pLineaTextBox txtUsuario;
        private pLineaTextBox txtCorreo;
        private pLineaTextBox txtClaveActual;
        private pLineaTextBox txtClaveNueva;
        private pDegradado pDegradado3;
        private System.Windows.Forms.Label label4;
        private pBoton btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuarioInvalido;
        private System.Windows.Forms.Label lblCorreoInvalido;
        private System.Windows.Forms.Label lblClaveInvalida;
        private System.Windows.Forms.Label label3;
        private pBoton btnMax;
        private pBoton pBoton1;
        private pBoton pBoton2;
    }
}