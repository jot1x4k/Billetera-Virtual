using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;

namespace testForms.pkgInterfaz
{
    public partial class formEnviar : Form
    {
        decimal saldo = 0;
        long idUsuario = 0;
        string cuentaNum = null;
        public formEnviar(long prm_usuarioActual, decimal prm_saldo, string prm_cuentaActual)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado1);

            lblSaldo.Text = prm_saldo.ToString("C2");

            saldo = prm_saldo;
            idUsuario = prm_usuarioActual;
            cuentaNum = prm_cuentaActual;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                }
            }
        }

        public formEnviar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Datos data = new Datos();

            var transferencia = data.fnc_transferencia(idUsuario, int.Parse(txtNumeroCuenta.TextBoxInterno.Text), int.Parse(txtMonto.TextBoxInterno.Text));

            if (transferencia == null)
            {
                MessageBox.Show("No se ha encontrado la cuenta destino, por favor revise los datos ingresados",
                    "Error al enviar dinero",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(transferencia.Value.fecha.ToString("G"));
                int referencia = int.Parse(transferencia.Value.referencia.ToString());

                formComprobante comprobante = new formComprobante(
                    int.Parse(txtNumeroCuenta.TextBoxInterno.Text),
                    int.Parse(txtMonto.TextBoxInterno.Text),
                    fecha,
                    referencia
                    );

                comprobante.ShowDialog();
                this.Close();
            }
        }

        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool campos = true;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    if (string.IsNullOrEmpty(linea.TextBoxInterno.Text) || linea.TextBoxInterno.Text == "")
                    {
                        campos = false; 
                        break;
                    }
                }
            }

            bool montoValido = false;
            bool cuentaValida = false;
            bool mismaCuenta = false;


            if (decimal.TryParse(txtMonto.TextBoxInterno.Text, out decimal monto))
            {
                montoValido = monto > 0 && monto <= saldo;
            }

            cuentaValida = (txtNumeroCuenta.TextBoxInterno.Text.Length == txtNumeroCuenta.limiteCaracteres);
            mismaCuenta = (!string.Equals(txtNumeroCuenta.TextBoxInterno.Text, cuentaNum));

            if (campos && montoValido && cuentaValida && mismaCuenta)
            {
                btnEnviar.Show();
                btnEnviar.Enabled = true;

                lblErrorMonto.Hide();
                lblErrorCuenta.Hide();
            }
            else
            {
                btnEnviar.Hide();
                btnEnviar.Enabled = false;

                lblErrorMonto.Visible = !montoValido;
                lblErrorCuenta.Visible = !cuentaValida;
                lblMismaCuenta.Visible = !mismaCuenta;
            }   
        }

        private void pBoton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formEnviar_Load(object sender, EventArgs e)
        {

        }

        private void pBoton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
