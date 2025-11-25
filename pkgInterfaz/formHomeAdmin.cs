using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;
using testForms.pkgLogica;

namespace testForms.pkgInterfaz
{
    public partial class formHomeAdmin : Form
    {
        Datos db = new Datos();

        public formHomeAdmin()
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void tbcAdmin_Enter(object sender, EventArgs e)
        {
        }

        private void pBoton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formHomeAdmin_Load(object sender, EventArgs e)
        {
            DataTable tabla = db.fnc_consultarSolicitudes();
            if (tabla == null || tabla.Rows.Count == 0)
            {
                dgvSolicitudes.Visible = false;
                lblNoSolicitudes.Visible = true;
                return;
            }

            foreach (DataGridViewColumn column in dgvSolicitudes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataView dv = new DataView(tabla);

            dgvSolicitudes.DataSource = dv;
            if (dv.Count == 0)
            {
                dgvSolicitudes.Visible = false;
                lblNoSolicitudes.Visible = true;
            }
            else
            {
                dgvSolicitudes.Visible = true;
                dgvSolicitudes.Enabled = true;
                lblNoSolicitudes.Visible = false;

                if (dgvSolicitudes.Columns.Contains("Ingresos"))
                {
                    this.dgvSolicitudes.Columns["Ingresos"].DefaultCellStyle.Format = "C";
                }
                if (dgvSolicitudes.Columns.Contains("Egresos"))
                {
                    this.dgvSolicitudes.Columns["Egresos"].DefaultCellStyle.Format = "C";
                }
                if (dgvSolicitudes.Columns.Contains("Fecha de solicitud"))
                {
                    this.dgvSolicitudes.Columns["Fecha de solicitud"].DefaultCellStyle.Format = ("D");
                }
            }
        }
    }
}
