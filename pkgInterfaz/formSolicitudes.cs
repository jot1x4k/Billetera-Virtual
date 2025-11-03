using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;
using testForms.pkgLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testForms.pkgInterfaz
{
    public partial class formSolicitudes : Form
    {
        long id_usuarioActual = 0;
        Usuario user = new Usuario();
        Datos data = new Datos();
        Dictionary<string, int> diccionarioMeses = new Dictionary<string, int>();
        DateTime fechaCreacion;
        DateTime fechaActual;

        public formSolicitudes()
        {
            InitializeComponent();
        }

        public formSolicitudes(long prm_idUsuarioActual)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado3);
            id_usuarioActual = prm_idUsuarioActual;

            int aux = 1;
            foreach (string mes in cmbMes.Items)
            {
                diccionarioMeses.Add(mes, aux);
                aux++;
            }

            lblErrorAnio.Hide();
            lblErrorMes.Hide();

            btnGenerarExtracto.BackColor = Color.DimGray;

            cmbMes.SelectionChangeCommitted += validarSeleccion;
            cmbAnio.SelectionChangeCommitted += validarSeleccion;
        }

        private void validarSeleccion(object sender, EventArgs e)
        {
            bool campoMes = false; 
            bool campoAnio = false;

            campoMes = cmbMes.SelectedItem != null;
            campoAnio = cmbAnio.SelectedItem != null;

            if (campoAnio && campoMes)
            {
                lblErrorMes.Hide();
                lblErrorAnio.Hide();

                btnGenerarExtracto.Enabled = true;
                btnGenerarExtracto.BackColor = Color.RoyalBlue;
            }
            else
            {
                lblErrorAnio.Visible = !campoAnio;
                lblErrorMes.Visible = !campoMes;
            }
        }

        private void tabExtracto_Enter(object sender, EventArgs e)
        {
            fechaCreacion = user.fnc_verificarFechaCreacion(id_usuarioActual);
            fechaActual = DateTime.Now;

            cmbAnio.Items.Clear();

            int anioInicio = fechaCreacion.Year;
            int anioFin = fechaActual.Year;

            for (int anio = anioFin; anio >= anioInicio; anio--)
            {
                cmbAnio.Items.Add(anio.ToString());
            }
        }

        private void btnGenerarExtracto_Click(object sender, EventArgs e)
        {
            int anio = 0;
            string mesTexto = "";
            try
            {
                anio = int.Parse(cmbAnio.Text);
                mesTexto = cmbMes.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El periodo es invalido, por favor revise los datos seleccionados" + ex);
                return;
            }


            int mesNumero = 0;

            diccionarioMeses.TryGetValue(mesTexto, out mesNumero);

            DateTime periodo = new DateTime(anio, mesNumero, 1);
            if (periodo.Month >= DateTime.Now.Month && periodo.Year >= DateTime.Now.Year
                || periodo <= fechaCreacion)
            {
                MessageBox.Show($"No existen extractos disponibles para el periodo de {cmbMes.Text} de {cmbAnio.Text}.");
                return;
            }

            var resultado = data.fnc_generarExtracto(id_usuarioActual, periodo);
            var infoCuenta = data.fnc_obtenerInfoCuenta(id_usuarioActual);

            decimal saldoInicio = resultado.Value.saldoInicio;
            decimal ingresos = resultado.Value.ingresos;
            decimal egresos = resultado.Value.egresos;
            decimal saldoFin = resultado.Value.saldoFin;
            DateTime fechaInicio = resultado.Value.fechaInicio;
            DateTime fechaFin = resultado.Value.fechaFin;

            string titular = infoCuenta.Value.nombre.ToString();
            string nombreLimpio = Regex.Replace(titular.Trim(), @"\s+", " ");
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            titular = ti.ToTitleCase(nombreLimpio.ToLower());

            int numeroCuenta = int.Parse(infoCuenta.Value.cuentaNum.ToString());
            formExtracto frmExtracto = new formExtracto (
                fechaInicio,
                fechaFin,
                saldoInicio,
                ingresos,
                egresos,
                saldoFin,
                titular,
                numeroCuenta,
                id_usuarioActual
                    );

            this.Close();
            frmExtracto.ShowDialog();

        }

        private void cmbAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
