namespace testForms.pkgInterfaz
{
    partial class formComprobante
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
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button1 = new testForms.pkgInterfaz.pBoton();
            this.pDegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.lblTransferencia.Location = new System.Drawing.Point(84, 16);
            this.lblTransferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(433, 49);
            this.lblTransferencia.TabIndex = 1;
            this.lblTransferencia.Text = "Transferencia exitosa";
            // 
            // pDegradado1
            // 
            this.pDegradado1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pDegradado1.Angle = 90F;
            this.pDegradado1.Controls.Add(this.label1);
            this.pDegradado1.Controls.Add(this.label4);
            this.pDegradado1.Controls.Add(this.lblCuentaDestino);
            this.pDegradado1.Controls.Add(this.label3);
            this.pDegradado1.Controls.Add(this.lblMonto);
            this.pDegradado1.Controls.Add(this.label2);
            this.pDegradado1.Controls.Add(this.lblReferencia);
            this.pDegradado1.Controls.Add(this.lblFecha);
            this.pDegradado1.HexColor1 = "white";
            this.pDegradado1.HexColor2 = "white";
            this.pDegradado1.Location = new System.Drawing.Point(0, 96);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(600, 216);
            this.pDegradado1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enviado a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Referencia:";
            // 
            // lblCuentaDestino
            // 
            this.lblCuentaDestino.AutoSize = true;
            this.lblCuentaDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaDestino.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaDestino.ForeColor = System.Drawing.Color.Black;
            this.lblCuentaDestino.Location = new System.Drawing.Point(156, 40);
            this.lblCuentaDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(163, 24);
            this.lblCuentaDestino.TabIndex = 34;
            this.lblCuentaDestino.Text = "CuentaDestino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(156, 72);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(77, 24);
            this.lblMonto.TabIndex = 35;
            this.lblMonto.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cantidad:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.Color.Black;
            this.lblReferencia.Location = new System.Drawing.Point(156, 136);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(122, 24);
            this.lblReferencia.TabIndex = 36;
            this.lblReferencia.Text = "Referencia";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(156, 104);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 24);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.button1.BorderRadius = 8;
            this.button1.BorderSize = 2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(225, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 44;
            this.button1.Text = "Aceptar";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTransferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formComprobante";
            this.pDegradado1.ResumeLayout(false);
            this.pDegradado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblCuentaDestino;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblFecha;
        private pBoton button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private pDegradado pDegradado1;
    }
}