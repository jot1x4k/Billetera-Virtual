namespace testForms.pkgInterfaz
{
    partial class formEnviar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.lblErrorCuenta = new System.Windows.Forms.Label();
            this.txtMonto = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtNumeroCuenta = new testForms.pkgInterfaz.pLineaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new testForms.pkgInterfaz.pBoton();
            this.label3 = new System.Windows.Forms.Label();
            this.pBoton2 = new testForms.pkgInterfaz.pBoton();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.lblMismaCuenta = new System.Windows.Forms.Label();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.pDegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 77);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enviar dinero";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(440, 258);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 24);
            this.lblSaldo.TabIndex = 28;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMonto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorMonto.Location = new System.Drawing.Point(432, 536);
            this.lblErrorMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(166, 17);
            this.lblErrorMonto.TabIndex = 29;
            this.lblErrorMonto.Text = "Ingrese un monto valido";
            this.lblErrorMonto.Visible = false;
            // 
            // lblErrorCuenta
            // 
            this.lblErrorCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorCuenta.AutoSize = true;
            this.lblErrorCuenta.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorCuenta.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorCuenta.Location = new System.Drawing.Point(432, 456);
            this.lblErrorCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCuenta.Name = "lblErrorCuenta";
            this.lblErrorCuenta.Size = new System.Drawing.Size(247, 17);
            this.lblErrorCuenta.TabIndex = 32;
            this.lblErrorCuenta.Text = "Ingrese un numero de cuenta valido";
            this.lblErrorCuenta.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMonto.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtMonto.esClave = false;
            this.txtMonto.label = "Monto";
            this.txtMonto.limiteCaracteres = 8;
            this.txtMonto.Location = new System.Drawing.Point(424, 480);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtMonto.placeholder = "Cantidad a enviar";
            this.txtMonto.Radius = 8;
            this.txtMonto.Size = new System.Drawing.Size(304, 55);
            this.txtMonto.TabIndex = 31;
            this.txtMonto.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroCuenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNumeroCuenta.esClave = false;
            this.txtNumeroCuenta.label = "Cuenta destino";
            this.txtNumeroCuenta.limiteCaracteres = 8;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(424, 400);
            this.txtNumeroCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtNumeroCuenta.placeholder = "Numero de cuenta";
            this.txtNumeroCuenta.Radius = 8;
            this.txtNumeroCuenta.Size = new System.Drawing.Size(304, 55);
            this.txtNumeroCuenta.TabIndex = 30;
            this.txtNumeroCuenta.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.btnEnviar.BorderRadius = 8;
            this.btnEnviar.BorderSize = 2;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(528, 568);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 56);
            this.btnEnviar.TabIndex = 44;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 44);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tu saldo disponible:";
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
            this.pBoton2.Location = new System.Drawing.Point(1016, 8);
            this.pBoton2.Name = "pBoton2";
            this.pBoton2.Size = new System.Drawing.Size(38, 24);
            this.pBoton2.TabIndex = 54;
            this.pBoton2.Text = "-";
            this.pBoton2.TextColor = System.Drawing.Color.White;
            this.pBoton2.UseVisualStyleBackColor = false;
            this.pBoton2.Click += new System.EventHandler(this.pBoton2_Click_1);
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
            this.pBoton1.Font = new System.Drawing.Font("Codec Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton1.ForeColor = System.Drawing.Color.White;
            this.pBoton1.Location = new System.Drawing.Point(1056, 8);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(38, 24);
            this.pBoton1.TabIndex = 53;
            this.pBoton1.Text = "X";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click);
            // 
            // lblMismaCuenta
            // 
            this.lblMismaCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMismaCuenta.AutoSize = true;
            this.lblMismaCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMismaCuenta.ForeColor = System.Drawing.Color.Brown;
            this.lblMismaCuenta.Location = new System.Drawing.Point(432, 456);
            this.lblMismaCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMismaCuenta.Name = "lblMismaCuenta";
            this.lblMismaCuenta.Size = new System.Drawing.Size(294, 17);
            this.lblMismaCuenta.TabIndex = 55;
            this.lblMismaCuenta.Text = "No puedes enviar dinero a tu misma cuenta";
            this.lblMismaCuenta.Visible = false;
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 180F;
            this.pDegradado1.BackColor = System.Drawing.Color.Transparent;
            this.pDegradado1.Controls.Add(this.pBoton2);
            this.pDegradado1.Controls.Add(this.pBoton1);
            this.pDegradado1.Controls.Add(this.label1);
            this.pDegradado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado1.HexColor1 = "#4450c9";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 0);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(1101, 232);
            this.pDegradado1.TabIndex = 56;
            // 
            // formEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1101, 718);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.lblMismaCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblErrorCuenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNumeroCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formEnviar";
            this.Text = "formEnviar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formEnviar_Load);
            this.pDegradado1.ResumeLayout(false);
            this.pDegradado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblErrorMonto;
        private pLineaTextBox txtNumeroCuenta;
        private pLineaTextBox txtMonto;
        private System.Windows.Forms.Label lblErrorCuenta;
        private System.Windows.Forms.Label label2;
        private pBoton btnEnviar;
        private System.Windows.Forms.Label label3;
        private pBoton pBoton2;
        private pBoton pBoton1;
        private System.Windows.Forms.Label lblMismaCuenta;
        private pDegradado pDegradado1;
    }
}