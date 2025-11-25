namespace testForms.pkgInterfaz
{
    partial class formHomeAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.lblNoSolicitudes = new System.Windows.Forms.Label();
            this.pDegradado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.Controls.Add(this.pBoton1);
            this.pDegradado1.Controls.Add(this.label2);
            this.pDegradado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado1.HexColor1 = "#ff7700";
            this.pDegradado1.HexColor2 = "#ffb700";
            this.pDegradado1.Location = new System.Drawing.Point(0, 0);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(1518, 144);
            this.pDegradado1.TabIndex = 22;
            // 
            // pBoton1
            // 
            this.pBoton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoton1.AutoSize = true;
            this.pBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BorderColor = System.Drawing.Color.White;
            this.pBoton1.BorderRadius = 5;
            this.pBoton1.BorderSize = 0;
            this.pBoton1.FlatAppearance.BorderSize = 0;
            this.pBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton1.ForeColor = System.Drawing.Color.White;
            this.pBoton1.Location = new System.Drawing.Point(1328, 56);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(175, 38);
            this.pBoton1.TabIndex = 59;
            this.pBoton1.Text = "Cerrar sesion";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 56);
            this.label2.TabIndex = 56;
            this.label2.Text = "Panel de administracion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 40);
            this.label1.TabIndex = 57;
            this.label1.Text = "Vista de solicitudes de productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSolicitudes.EnableHeadersVisualStyles = false;
            this.dgvSolicitudes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvSolicitudes.Location = new System.Drawing.Point(16, 200);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitudes.RowTemplate.Height = 24;
            this.dgvSolicitudes.Size = new System.Drawing.Size(1496, 680);
            this.dgvSolicitudes.TabIndex = 58;
            // 
            // lblNoSolicitudes
            // 
            this.lblNoSolicitudes.AutoSize = true;
            this.lblNoSolicitudes.BackColor = System.Drawing.Color.Transparent;
            this.lblNoSolicitudes.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.lblNoSolicitudes.ForeColor = System.Drawing.Color.Black;
            this.lblNoSolicitudes.Location = new System.Drawing.Point(507, 224);
            this.lblNoSolicitudes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoSolicitudes.Name = "lblNoSolicitudes";
            this.lblNoSolicitudes.Size = new System.Drawing.Size(505, 40);
            this.lblNoSolicitudes.TabIndex = 59;
            this.lblNoSolicitudes.Text = "No se encontraron solicitudes";
            this.lblNoSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoSolicitudes.Visible = false;
            // 
            // formHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1518, 885);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.lblNoSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formHomeAdmin";
            this.Text = "formHomeAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formHomeAdmin_Load);
            this.pDegradado1.ResumeLayout(false);
            this.pDegradado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pDegradado pDegradado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private pBoton pBoton1;
        private System.Windows.Forms.Label lblNoSolicitudes;
    }
}