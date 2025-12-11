using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;

namespace testForms.pkgInterfaz
{
    public partial class formHomeCliente : Form
    {
        long id_usuarioActual = 0;
        decimal saldo = 0;

        public formHomeCliente()
        {
            InitializeComponent();
        }

        public formHomeCliente(long prm_idUsuarioActual)
        {
            id_usuarioActual = prm_idUsuarioActual;
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado1);

            fnc_cargarDatosCuenta(id_usuarioActual);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formActualizarCliente formAct = new formActualizarCliente(id_usuarioActual))
            {
                formAct.ShowDialog();
                this.Hide();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formEnviar formEnv = new formEnviar(id_usuarioActual, saldo, lblCuentaNum.Text))
            {
                formEnv.ShowDialog();
                this.Hide();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }

        private void fnc_cargarDatosCuenta (long prm_idUsuarioActual)
        {
            var data = new Datos();
            var infoCuenta = data.fnc_obtenerInfoCuenta(prm_idUsuarioActual);
            string nombreCompleto = infoCuenta.Value.nombre.ToString();
            string nombreLimpio = Regex.Replace(nombreCompleto.Trim(), @"\s+", " ");
            string[] partes = nombreLimpio.Split(' ');
            if (partes.Length > 0)
            {
                string primerNombre = partes[0];
                if (string.IsNullOrEmpty(primerNombre)) nombreLimpio = string.Empty;

                nombreLimpio =  char.ToUpper(primerNombre[0]) + primerNombre.Substring(1).ToLower();
            }
            lblNombre.Text = nombreLimpio;
            lblCuentaNum.Text = infoCuenta.Value.cuentaNum.ToString();
            saldo = infoCuenta.Value.saldoCuenta;
            lblSaldo.Text = saldo.ToString("C2");  
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formMovimientos frmMov = new formMovimientos(id_usuarioActual))
            {
                frmMov.ShowDialog();
                this.Hide();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formSolicitudes frmSolicitudes = new formSolicitudes(id_usuarioActual))
            {
                frmSolicitudes.ShowDialog();
                this.Hide();
            }

            this.Show();
        }

        private void pBoton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            fnc_cargarDatosCuenta(id_usuarioActual);
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
