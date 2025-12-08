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

namespace testForms.pkgInterfaz
{
    public partial class formExtracto : Form
    {
        Datos data = new Datos();
        long id_usuarioActual = 0;
        DateTime fechaInicio, fechaFin;

        public formExtracto()
        {
            InitializeComponent();
        }
        public formExtracto(DateTime fechaInicio, DateTime fechaFin, decimal saldoInicio, decimal ingresos, decimal egresos, decimal saldoFin, string titular, int numeroCuenta, long prm_idUsuario)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado3);
            lblPeriodo.Text = $"{fechaInicio.ToString("dd/MM/yyyy")} - {fechaFin.ToString("dd/MM/yyyy")}";
            lblSaldoInicio.Text = $"{saldoInicio.ToString("C")}";
            lblIngresos.Text = $"{ingresos.ToString("C")}";
            lblEgresos.Text = $"{egresos.ToString("C")}";
            lblSaldoFin.Text = $"{saldoFin.ToString("C")}";
            lblCuenta.Text = $"{numeroCuenta}";
            lblTitular.Text = $"{titular}";
            id_usuarioActual = prm_idUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;

            lblNoMovimientos.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMovimientos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMovimientos.ClearSelection();
        }

        private void formExtracto_Load(object sender, EventArgs e)
        {
            DataTable tabla = data.fnc_consultarMovimientos(id_usuarioActual);
            dgvMovimientos.DataSource = tabla;

            if (tabla == null || tabla.Rows.Count == 0)
            {
                dgvMovimientos.Visible = false;
                lblNoMovimientos.Visible = true;
                return;
            }

            DataView dv = new DataView(tabla);
            dv.RowFilter = $"Fecha >= #{fechaInicio:yyyy-MM-dd}# AND Fecha <= #{fechaFin:yyyy-MM-dd}#";

            foreach (DataGridViewColumn column in dgvMovimientos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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
