namespace testForms.pkgInterfaz
{
    partial class formSolicitudes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExtracto = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorAnio = new System.Windows.Forms.Label();
            this.lblErrorMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblDatosObligatorios = new System.Windows.Forms.Label();
            this.lblNac = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.cmbNacAnio = new System.Windows.Forms.ComboBox();
            this.cmbNacDia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNacMes = new System.Windows.Forms.ComboBox();
            this.cmbExpAnio = new System.Windows.Forms.ComboBox();
            this.cmbExpDia = new System.Windows.Forms.ComboBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.cmbExpMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pDegradado3 = new testForms.pkgInterfaz.pDegradado();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new testForms.pkgInterfaz.pBoton();
            this.btnGenerarExtracto = new testForms.pkgInterfaz.pBoton();
            this.btnSolicitarProducto = new testForms.pkgInterfaz.pBoton();
            this.txtCorreo = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtTelefono = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtEgresos = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtIngresos = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtSApellido = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPApellido = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtSNombre = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPNombre = new testForms.pkgInterfaz.pLineaTextBox();
            this.tabControl1.SuspendLayout();
            this.tabExtracto.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.pDegradado3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabExtracto);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 136);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1548, 830);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExtracto
            // 
            this.tabExtracto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabExtracto.Controls.Add(this.btnGenerarExtracto);
            this.tabExtracto.Controls.Add(this.label3);
            this.tabExtracto.Controls.Add(this.lblErrorAnio);
            this.tabExtracto.Controls.Add(this.lblErrorMes);
            this.tabExtracto.Controls.Add(this.label1);
            this.tabExtracto.Controls.Add(this.cmbAnio);
            this.tabExtracto.Controls.Add(this.cmbMes);
            this.tabExtracto.Controls.Add(this.lblEntrar);
            this.tabExtracto.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabExtracto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExtracto.ForeColor = System.Drawing.Color.Black;
            this.tabExtracto.Location = new System.Drawing.Point(4, 34);
            this.tabExtracto.Margin = new System.Windows.Forms.Padding(0);
            this.tabExtracto.Name = "tabExtracto";
            this.tabExtracto.Size = new System.Drawing.Size(1540, 792);
            this.tabExtracto.TabIndex = 0;
            this.tabExtracto.Text = "Extracto de cuenta";
            this.tabExtracto.Enter += new System.EventHandler(this.tabExtracto_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Año";
            // 
            // lblErrorAnio
            // 
            this.lblErrorAnio.CausesValidation = false;
            this.lblErrorAnio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorAnio.Location = new System.Drawing.Point(143, 193);
            this.lblErrorAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorAnio.Name = "lblErrorAnio";
            this.lblErrorAnio.Size = new System.Drawing.Size(134, 23);
            this.lblErrorAnio.TabIndex = 31;
            this.lblErrorAnio.Text = "Seleccione un año";
            this.lblErrorAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorMes
            // 
            this.lblErrorMes.CausesValidation = false;
            this.lblErrorMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorMes.Location = new System.Drawing.Point(143, 128);
            this.lblErrorMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMes.Name = "lblErrorMes";
            this.lblErrorMes.Size = new System.Drawing.Size(134, 23);
            this.lblErrorMes.TabIndex = 30;
            this.lblErrorMes.Text = "Seleccione un mes";
            this.lblErrorMes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mes";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(117, 157);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(187, 33);
            this.cmbAnio.TabIndex = 3;
            this.cmbAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAnio_KeyPress);
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiempre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(117, 89);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(187, 33);
            this.cmbMes.TabIndex = 2;
            this.cmbMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMes_KeyPress);
            // 
            // lblEntrar
            // 
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(0, 0);
            this.lblEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(680, 72);
            this.lblEntrar.TabIndex = 1;
            this.lblEntrar.Text = "Generar extracto de cuenta";
            // 
            // tabProductos
            // 
            this.tabProductos.AutoScroll = true;
            this.tabProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabProductos.Controls.Add(this.lblProd);
            this.tabProductos.Controls.Add(this.lblEst);
            this.tabProductos.Controls.Add(this.lblDatosObligatorios);
            this.tabProductos.Controls.Add(this.lblNac);
            this.tabProductos.Controls.Add(this.lblExp);
            this.tabProductos.Controls.Add(this.label12);
            this.tabProductos.Controls.Add(this.label11);
            this.tabProductos.Controls.Add(this.label10);
            this.tabProductos.Controls.Add(this.label9);
            this.tabProductos.Controls.Add(this.cmbProducto);
            this.tabProductos.Controls.Add(this.label8);
            this.tabProductos.Controls.Add(this.label7);
            this.tabProductos.Controls.Add(this.label6);
            this.tabProductos.Controls.Add(this.cmbEstudios);
            this.tabProductos.Controls.Add(this.cmbNacAnio);
            this.tabProductos.Controls.Add(this.cmbNacDia);
            this.tabProductos.Controls.Add(this.label5);
            this.tabProductos.Controls.Add(this.cmbNacMes);
            this.tabProductos.Controls.Add(this.cmbExpAnio);
            this.tabProductos.Controls.Add(this.cmbExpDia);
            this.tabProductos.Controls.Add(this.lblFechaNac);
            this.tabProductos.Controls.Add(this.cmbExpMes);
            this.tabProductos.Controls.Add(this.label2);
            this.tabProductos.Controls.Add(this.btnSolicitarProducto);
            this.tabProductos.Controls.Add(this.txtCorreo);
            this.tabProductos.Controls.Add(this.txtTelefono);
            this.tabProductos.Controls.Add(this.txtEgresos);
            this.tabProductos.Controls.Add(this.txtIngresos);
            this.tabProductos.Controls.Add(this.txtSApellido);
            this.tabProductos.Controls.Add(this.txtPApellido);
            this.tabProductos.Controls.Add(this.txtSNombre);
            this.tabProductos.Controls.Add(this.txtPNombre);
            this.tabProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabProductos.Location = new System.Drawing.Point(4, 34);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(1540, 792);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "Productos financieros";
            this.tabProductos.Click += new System.EventHandler(this.tabProductos_Click);
            this.tabProductos.Enter += new System.EventHandler(this.tabProductos_Enter);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.CausesValidation = false;
            this.lblProd.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProd.Location = new System.Drawing.Point(483, 680);
            this.lblProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(75, 17);
            this.lblProd.TabIndex = 75;
            this.lblProd.Text = "error prod";
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProd.Visible = false;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.CausesValidation = false;
            this.lblEst.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblEst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEst.Location = new System.Drawing.Point(728, 368);
            this.lblEst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(64, 17);
            this.lblEst.TabIndex = 74;
            this.lblEst.Text = "error est";
            this.lblEst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEst.Visible = false;
            // 
            // lblDatosObligatorios
            // 
            this.lblDatosObligatorios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatosObligatorios.AutoSize = true;
            this.lblDatosObligatorios.CausesValidation = false;
            this.lblDatosObligatorios.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblDatosObligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosObligatorios.Location = new System.Drawing.Point(348, 768);
            this.lblDatosObligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(345, 17);
            this.lblDatosObligatorios.TabIndex = 73;
            this.lblDatosObligatorios.Text = "Ingrese los campos obligatorios (*) para continuar";
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.CausesValidation = false;
            this.lblNac.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNac.Location = new System.Drawing.Point(728, 320);
            this.lblNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(69, 17);
            this.lblNac.TabIndex = 72;
            this.lblNac.Text = "error nac";
            this.lblNac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNac.Visible = false;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.CausesValidation = false;
            this.lblExp.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExp.Location = new System.Drawing.Point(728, 280);
            this.lblExp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(67, 17);
            this.lblExp.TabIndex = 71;
            this.lblExp.Text = "error exp";
            this.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExp.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(392, 536);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(304, 36);
            this.label12.TabIndex = 69;
            this.label12.Text = "Acerca de tu solicitud";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(408, 400);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 36);
            this.label11.TabIndex = 68;
            this.label11.Text = "Datos de contacto";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(400, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 32);
            this.label10.TabIndex = 67;
            this.label10.Text = "Datos personales";
            // 
            // label9
            // 
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 648);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Producto de interes";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Ahorros e Inversiones",
            "Subsidios",
            "Cuenta de negocio",
            "Seguro de los Andes",
            "Tarjeta de credito"});
            this.cmbProducto.Location = new System.Drawing.Point(200, 640);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(834, 33);
            this.cmbProducto.TabIndex = 65;
            this.cmbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProducto_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(536, 592);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 592);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(160, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nivel de estudios";
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Items.AddRange(new object[] {
            "Primaria incompleta",
            "Primaria completa",
            "Secundaria/Bachillerato incompleta",
            "Secundaria/Bachillerato completa",
            "Tecnico incompleto",
            "Tecnico completo",
            "Tecnologo incompleto",
            "Tecnologo completo",
            "Universitario/Profesional incompleto",
            "Universitario/Profesional completo",
            "Postgrado incompleto",
            "Postgrado completo",
            "Especializacion",
            "Maestria",
            "Doctorado"});
            this.cmbEstudios.Location = new System.Drawing.Point(328, 360);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(392, 33);
            this.cmbEstudios.TabIndex = 57;
            this.cmbEstudios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstudios_KeyPress);
            // 
            // cmbNacAnio
            // 
            this.cmbNacAnio.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacAnio.FormattingEnabled = true;
            this.cmbNacAnio.Location = new System.Drawing.Point(600, 315);
            this.cmbNacAnio.Name = "cmbNacAnio";
            this.cmbNacAnio.Size = new System.Drawing.Size(120, 33);
            this.cmbNacAnio.TabIndex = 56;
            this.cmbNacAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNacAnio_KeyPress);
            // 
            // cmbNacDia
            // 
            this.cmbNacDia.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacDia.FormattingEnabled = true;
            this.cmbNacDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbNacDia.Location = new System.Drawing.Point(328, 315);
            this.cmbNacDia.Name = "cmbNacDia";
            this.cmbNacDia.Size = new System.Drawing.Size(120, 33);
            this.cmbNacDia.TabIndex = 55;
            this.cmbNacDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNacDia_KeyPress);
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(130, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // cmbNacMes
            // 
            this.cmbNacMes.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacMes.FormattingEnabled = true;
            this.cmbNacMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbNacMes.Location = new System.Drawing.Point(464, 315);
            this.cmbNacMes.Name = "cmbNacMes";
            this.cmbNacMes.Size = new System.Drawing.Size(120, 33);
            this.cmbNacMes.TabIndex = 53;
            this.cmbNacMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNacMes_KeyPress);
            // 
            // cmbExpAnio
            // 
            this.cmbExpAnio.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpAnio.FormattingEnabled = true;
            this.cmbExpAnio.Location = new System.Drawing.Point(600, 272);
            this.cmbExpAnio.Name = "cmbExpAnio";
            this.cmbExpAnio.Size = new System.Drawing.Size(120, 33);
            this.cmbExpAnio.TabIndex = 52;
            this.cmbExpAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbExpAnio_KeyPress);
            // 
            // cmbExpDia
            // 
            this.cmbExpDia.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpDia.FormattingEnabled = true;
            this.cmbExpDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbExpDia.Location = new System.Drawing.Point(328, 272);
            this.cmbExpDia.Name = "cmbExpDia";
            this.cmbExpDia.Size = new System.Drawing.Size(120, 33);
            this.cmbExpDia.TabIndex = 51;
            this.cmbExpDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbExpDia_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.CausesValidation = false;
            this.lblFechaNac.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNac.Location = new System.Drawing.Point(18, 280);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(286, 23);
            this.lblFechaNac.TabIndex = 50;
            this.lblFechaNac.Text = "Fecha de expedicion del documento";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // cmbExpMes
            // 
            this.cmbExpMes.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpMes.FormattingEnabled = true;
            this.cmbExpMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbExpMes.Location = new System.Drawing.Point(464, 272);
            this.cmbExpMes.Name = "cmbExpMes";
            this.cmbExpMes.Size = new System.Drawing.Size(120, 33);
            this.cmbExpMes.TabIndex = 49;
            this.cmbExpMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbExpMes_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicitud de productos financieros";
            // 
            // pDegradado3
            // 
            this.pDegradado3.Angle = 90F;
            this.pDegradado3.BackColor = System.Drawing.Color.Transparent;
            this.pDegradado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pDegradado3.Controls.Add(this.label4);
            this.pDegradado3.Controls.Add(this.btnVolver);
            this.pDegradado3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado3.HexColor1 = "#4450c9";
            this.pDegradado3.HexColor2 = "#5C69F5";
            this.pDegradado3.Location = new System.Drawing.Point(0, 0);
            this.pDegradado3.Margin = new System.Windows.Forms.Padding(0);
            this.pDegradado3.Name = "pDegradado3";
            this.pDegradado3.Size = new System.Drawing.Size(1563, 120);
            this.pDegradado3.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 77);
            this.label4.TabIndex = 54;
            this.label4.Text = "Solicitudes";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnVolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnVolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.btnVolver.BorderRadius = 8;
            this.btnVolver.BorderSize = 2;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1427, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(128, 48);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGenerarExtracto
            // 
            this.btnGenerarExtracto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnGenerarExtracto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnGenerarExtracto.BorderColor = System.Drawing.Color.Empty;
            this.btnGenerarExtracto.BorderRadius = 8;
            this.btnGenerarExtracto.BorderSize = 2;
            this.btnGenerarExtracto.Enabled = false;
            this.btnGenerarExtracto.FlatAppearance.BorderSize = 0;
            this.btnGenerarExtracto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarExtracto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarExtracto.ForeColor = System.Drawing.Color.White;
            this.btnGenerarExtracto.Location = new System.Drawing.Point(144, 224);
            this.btnGenerarExtracto.Name = "btnGenerarExtracto";
            this.btnGenerarExtracto.Size = new System.Drawing.Size(128, 56);
            this.btnGenerarExtracto.TabIndex = 55;
            this.btnGenerarExtracto.Text = "Generar extracto";
            this.btnGenerarExtracto.TextColor = System.Drawing.Color.White;
            this.btnGenerarExtracto.UseVisualStyleBackColor = false;
            this.btnGenerarExtracto.Click += new System.EventHandler(this.btnGenerarExtracto_Click);
            // 
            // btnSolicitarProducto
            // 
            this.btnSolicitarProducto.AutoSize = true;
            this.btnSolicitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnSolicitarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnSolicitarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSolicitarProducto.BorderRadius = 8;
            this.btnSolicitarProducto.BorderSize = 0;
            this.btnSolicitarProducto.Enabled = false;
            this.btnSolicitarProducto.FlatAppearance.BorderSize = 0;
            this.btnSolicitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarProducto.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnSolicitarProducto.Location = new System.Drawing.Point(445, 712);
            this.btnSolicitarProducto.Name = "btnSolicitarProducto";
            this.btnSolicitarProducto.Size = new System.Drawing.Size(150, 49);
            this.btnSolicitarProducto.TabIndex = 70;
            this.btnSolicitarProducto.Text = "Solicitar";
            this.btnSolicitarProducto.TextColor = System.Drawing.Color.White;
            this.btnSolicitarProducto.UseVisualStyleBackColor = false;
            this.btnSolicitarProducto.Click += new System.EventHandler(this.btnSolicitarProducto_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtCorreo.esClave = false;
            this.txtCorreo.label = "Correo Electronico";
            this.txtCorreo.limiteCaracteres = 50;
            this.txtCorreo.Location = new System.Drawing.Point(528, 448);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtCorreo.placeholder = "ej: example@mail.com";
            this.txtCorreo.Radius = 8;
            this.txtCorreo.Size = new System.Drawing.Size(496, 56);
            this.txtCorreo.TabIndex = 64;
            this.txtCorreo.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtTelefono.esClave = false;
            this.txtTelefono.label = "Numero telefonico";
            this.txtTelefono.limiteCaracteres = 10;
            this.txtTelefono.Location = new System.Drawing.Point(16, 448);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtTelefono.placeholder = "Maximo 10 digitos";
            this.txtTelefono.Radius = 8;
            this.txtTelefono.Size = new System.Drawing.Size(496, 56);
            this.txtTelefono.TabIndex = 61;
            this.txtTelefono.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtEgresos
            // 
            this.txtEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtEgresos.esClave = false;
            this.txtEgresos.label = "Egresos mensuales";
            this.txtEgresos.limiteCaracteres = 15;
            this.txtEgresos.Location = new System.Drawing.Point(536, 576);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtEgresos.placeholder = " ";
            this.txtEgresos.Radius = 8;
            this.txtEgresos.Size = new System.Drawing.Size(496, 56);
            this.txtEgresos.TabIndex = 60;
            this.txtEgresos.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtIngresos
            // 
            this.txtIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtIngresos.esClave = false;
            this.txtIngresos.label = "Ingresos mensuales";
            this.txtIngresos.limiteCaracteres = 15;
            this.txtIngresos.Location = new System.Drawing.Point(16, 576);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtIngresos.placeholder = " ";
            this.txtIngresos.Radius = 8;
            this.txtIngresos.Size = new System.Drawing.Size(504, 56);
            this.txtIngresos.TabIndex = 59;
            this.txtIngresos.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtSApellido
            // 
            this.txtSApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtSApellido.esClave = false;
            this.txtSApellido.label = "Segundo apellido";
            this.txtSApellido.limiteCaracteres = 20;
            this.txtSApellido.Location = new System.Drawing.Point(528, 195);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtSApellido.placeholder = "(opcional)";
            this.txtSApellido.Radius = 8;
            this.txtSApellido.Size = new System.Drawing.Size(496, 56);
            this.txtSApellido.TabIndex = 6;
            this.txtSApellido.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // txtPApellido
            // 
            this.txtPApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtPApellido.esClave = false;
            this.txtPApellido.label = "Primer apellido";
            this.txtPApellido.limiteCaracteres = 20;
            this.txtPApellido.Location = new System.Drawing.Point(16, 195);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPApellido.placeholder = "  ";
            this.txtPApellido.Radius = 8;
            this.txtPApellido.Size = new System.Drawing.Size(496, 56);
            this.txtPApellido.TabIndex = 5;
            this.txtPApellido.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // txtSNombre
            // 
            this.txtSNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtSNombre.esClave = false;
            this.txtSNombre.label = "Segundo nombre";
            this.txtSNombre.limiteCaracteres = 20;
            this.txtSNombre.Location = new System.Drawing.Point(528, 123);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtSNombre.placeholder = "(opcional)";
            this.txtSNombre.Radius = 8;
            this.txtSNombre.Size = new System.Drawing.Size(496, 56);
            this.txtSNombre.TabIndex = 4;
            this.txtSNombre.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // txtPNombre
            // 
            this.txtPNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.txtPNombre.esClave = false;
            this.txtPNombre.label = "Primer nombre";
            this.txtPNombre.limiteCaracteres = 20;
            this.txtPNombre.Location = new System.Drawing.Point(16, 123);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPNombre.placeholder = " ";
            this.txtPNombre.Radius = 8;
            this.txtPNombre.Size = new System.Drawing.Size(496, 56);
            this.txtPNombre.TabIndex = 3;
            this.txtPNombre.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // formSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1563, 966);
            this.Controls.Add(this.pDegradado3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSolicitudes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabExtracto.ResumeLayout(false);
            this.tabExtracto.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.pDegradado3.ResumeLayout(false);
            this.pDegradado3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExtracto;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblErrorAnio;
        private System.Windows.Forms.Label lblErrorMes;
        private System.Windows.Forms.Label label3;
        private pBoton btnVolver;
        private pDegradado pDegradado3;
        private System.Windows.Forms.Label label4;
        private pBoton btnGenerarExtracto;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Label label2;
        private pLineaTextBox txtSApellido;
        private pLineaTextBox txtPApellido;
        private pLineaTextBox txtSNombre;
        private pLineaTextBox txtPNombre;
        private System.Windows.Forms.ComboBox cmbNacAnio;
        private System.Windows.Forms.ComboBox cmbNacDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNacMes;
        private System.Windows.Forms.ComboBox cmbExpAnio;
        private System.Windows.Forms.ComboBox cmbExpDia;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.ComboBox cmbExpMes;
        private pLineaTextBox txtEgresos;
        private pLineaTextBox txtIngresos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private pLineaTextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbProducto;
        private pLineaTextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private pBoton btnSolicitarProducto;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblDatosObligatorios;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblProd;
    }
}