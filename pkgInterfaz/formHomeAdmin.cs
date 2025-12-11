using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;
using testForms.pkgLogica;
using static System.Net.Mime.MediaTypeNames;

namespace testForms.pkgInterfaz
{
    public partial class formHomeAdmin : Form
    {
        Datos db = new Datos();
        DataTable tabla;
        DataView vista;

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
            tabla = db.fnc_consultarSolicitudes();
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

            vista = new DataView(tabla);

            dgvSolicitudes.DataSource = vista;
            if (vista.Count == 0)
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

        private void pLineaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vista.RowFilter = "Convert([ID del solicitante], 'System.String') LIKE '%" + txtFiltro.TextBoxInterno.Text + "%'";
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            bool hayFilaSeleccionada = dgvSolicitudes.SelectedRows.Count > 0;

            btnAprobar.Visible = hayFilaSeleccionada;
            btnRechazar.Visible = hayFilaSeleccionada;
        }

        private void dgvSolicitudes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSolicitudes.ClearSelection();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            ActualizarEstadoSolicitud("Aprobada");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            ActualizarEstadoSolicitud("Rechazada");
        }

        private void ActualizarEstadoSolicitud(string nuevoEstado)
        {
            if (dgvSolicitudes.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una solicitud.");
                return;
            }

            int filaActual = dgvSolicitudes.CurrentCell.RowIndex;

            int idRemitente = int.Parse(
                dgvSolicitudes.Rows[filaActual].Cells["Referencia"].Value.ToString()
            );

            int resultado = db.fnc_actualizarSolicitud(idRemitente, nuevoEstado);

            if (resultado > 0)
            {
                MessageBox.Show($"La solicitud fue {nuevoEstado.ToLower()} correctamente.");

                RecargarFormulario();
            }
            else
            {
                return;
            }
        }
        public void RecargarFormulario()
        {
            formHomeAdmin_Load(null, null);
        }

    }
}
