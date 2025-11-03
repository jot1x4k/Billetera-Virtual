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
    public partial class formMovimientos : Form
    {
        Datos data = new Datos();
        long id_usuarioActual = 0;

        public formMovimientos()
        {
            InitializeComponent();
        }

        public formMovimientos(long prm_idUsuario)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this);
            dgvMovimientos.Enabled = false;
            dgvMovimientos.Hide();

            id_usuarioActual = prm_idUsuario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMovimientos_Load(object sender, EventArgs e)
        {
            DataTable tabla = data.fnc_consultarMovimientos(id_usuarioActual);
            dgvMovimientos.DataSource = tabla;

            if (tabla == null || tabla.Rows.Count == 0)
            {
                dgvMovimientos.Visible = false;
                lblNoMovimientos.Visible = true;
                return;
            }

            foreach (DataGridViewColumn column in dgvMovimientos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataView dv = new DataView(tabla); 
            DateTime fechaLimiteSuperior = DateTime.Today.AddDays(1);
            DateTime fechaLimiteInferior = DateTime.Today.AddDays(-7);

            dv.RowFilter = $"Fecha >= #{fechaLimiteInferior:yyyy-MM-dd}# AND Fecha < #{fechaLimiteSuperior:yyyy-MM-dd}#";

            dgvMovimientos.DataSource = dv;
            if (dv.Count == 0)
            {
                dgvMovimientos.Visible = false;
                lblNoMovimientos.Visible = true;
            }
            else
            {
                dgvMovimientos.Visible = true;
                dgvMovimientos.Enabled = true;
                lblNoMovimientos.Visible = false;

                if (dgvMovimientos.Columns.Contains("Monto"))
                {
                    this.dgvMovimientos.Columns["Monto"].DefaultCellStyle.Format = "C";
                }
                if (dgvMovimientos.Columns.Contains("SaldoAnterior"))
                {
                    this.dgvMovimientos.Columns["SaldoAnterior"].DefaultCellStyle.Format = "C";
                }
                if (dgvMovimientos.Columns.Contains("SaldoPosterior"))
                {
                    this.dgvMovimientos.Columns["SaldoPosterior"].DefaultCellStyle.Format = "C";
                }
                if (dgvMovimientos.Columns.Contains("Fecha"))
                {
                    this.dgvMovimientos.Columns["Fecha"].DefaultCellStyle.Format = ("D");
                } 

                if (dgvMovimientos.Columns.Contains("TipoMovimiento") && dgvMovimientos.Columns.Contains("Monto"))
                {
                    foreach (DataGridViewRow row in dgvMovimientos.Rows)
                    {
                        object tipoMovimientoValue = row.Cells["TipoMovimiento"].Value;
                        if (tipoMovimientoValue == null) continue;

                        string estado = tipoMovimientoValue.ToString().ToUpperInvariant();

                        DataGridViewCell cellMonto = row.Cells["Monto"];

                        if (estado == "ENVIADO")
                        {
                            cellMonto.Style.ForeColor = ColorTranslator.FromHtml("#b50404");
                            cellMonto.Style.Format = "-$#,##0.00";
                        }
                        else if (estado == "RECIBIDO")
                        {
                            cellMonto.Style.ForeColor = ColorTranslator.FromHtml("#0eb806");
                            cellMonto.Style.Format = "+$#,##0.00";
                        }
                    }
                }
            }
        }
    }
}
