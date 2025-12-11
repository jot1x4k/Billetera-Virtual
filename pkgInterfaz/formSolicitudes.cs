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
        string nombre;
        Usuario user = new Usuario();
        Datos data = new Datos();
        Dictionary<string, int> diccionarioMeses = new Dictionary<string, int>();
        DateTime fechaCreacion;
        DateTime fechaActual;
        DateTime fechaExp;
        DateTime fechaNac;
        string cadenaFechaExp;
        bool campoEst;
        bool campoProd, campoAct, campoTiempo;

        public formSolicitudes()
        {
            InitializeComponent();
        }

        public formSolicitudes(long prm_idUsuarioActual)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado3);
            tabProductos.AutoScroll = true;
            tabProductos.AutoScrollMinSize = new Size(0, tabProductos.PreferredSize.Height);
            var resultado = data.fnc_obtenerInfoCuenta(prm_idUsuarioActual);
            nombre = resultado.Value.nombre;
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

            cmbEstudios.SelectionChangeCommitted += validarCmbSolicitud;
            cmbProducto.SelectionChangeCommitted += validarCmbSolicitud;
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
                MessageBox.Show($"No existen extractos disponibles para el periodo de {cmbMes.Text} de {cmbAnio.Text}.",
                                "Informacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
            using   (formExtracto frmExtracto = new formExtracto (
                                                                fechaInicio,
                                                                fechaFin,
                                                                saldoInicio,
                                                                ingresos,
                                                                egresos,
                                                                saldoFin,
                                                                titular,
                                                                numeroCuenta,
                                                                id_usuarioActual)
                    )
            {
                frmExtracto.ShowDialog();
            }
            
            this.Close();

        }
        /**
        FIN PAGE EXTRACTO +=============================================================================================================
         **/
        private void validarCmbSolicitud(object sender, EventArgs e)
        {
            campoEst = cmbEstudios.SelectedItem != null;
            campoProd = cmbProducto.SelectedItem != null;
            campoAct = cmbActividad.SelectedItem != null;
            campoTiempo = cmbTiempo.SelectedItem != null;

            bool formularioValido = campoEst && campoProd && campoAct && campoTiempo;

            lblEst.Visible = !campoEst;
            lblEst.Text = "Seleccione una opción de la lista";

            lblProd.Visible = !campoProd;
            lblProd.Text = "Seleccione el producto que desea solicitar";

            lblActividad.Visible = !campoAct;
            lblActividad.Text = "Seleccione su actividad económica";

            lblTiempo.Visible = !campoTiempo;
            lblTiempo.Text = "Seleccione el tiempo de la actividad";
        }



        private void btnSolicitarProducto_Click(object sender, EventArgs e)
        {

            string v_fechaExp = cadenaFechaExp;
            string v_estudios = cmbEstudios.Text;
            long v_telefono = long.Parse(txtTelefono.TextBoxInterno.Text);
            string v_correo = txtCorreo.TextBoxInterno.Text;
            long v_ingresos = long.Parse(txtIngresos.TextBoxInterno.Text);
            long v_egresos = long.Parse(txtEgresos.TextBoxInterno.Text);
            string v_producto = cmbProducto.Text;
            string v_actividad = cmbActividad.Text;
            string v_tiempo = cmbTiempo.Text;

            try
            {
                int resultadoDml = data.fnc_registrarProducto(nombre, id_usuarioActual, v_fechaExp, v_estudios, v_telefono, v_correo, v_ingresos, v_egresos, v_producto, v_actividad, v_tiempo);
                if (resultadoDml > 0) 
                {
                    MessageBox.Show("Solicitud realizada con exito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya ha realizado una solicitud de este producto" + ex);
            }
        }

        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool camposValidos = true;

            bool fechaExpCompleta =
                !string.IsNullOrWhiteSpace(cmbExpDia.Text) &&
                !string.IsNullOrWhiteSpace(cmbExpMes.Text) &&
                !string.IsNullOrWhiteSpace(cmbExpAnio.Text);

            foreach (Control ctrl in tabProductos.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    bool valido = ValidarCampoEspecifico(linea);
                    if (!valido) camposValidos = false;
                }
            }

            int mesExp = 0;
            diccionarioMeses.TryGetValue(cmbExpMes.Text, out mesExp);

            cadenaFechaExp = $"{cmbExpDia.Text}/{mesExp}/{cmbExpAnio.Text}";

            bool fechaExpValida = false;

            if (fechaExpCompleta)
            {
                fechaExpValida = DateTime.TryParseExact(
                    cadenaFechaExp,
                    "d/M/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out fechaExp
                );
            }

            if (!fechaExpCompleta)
            {
                lblExp.Show();
                lblExp.Text = "Fecha incompleta.";
                camposValidos = false;
            }
            else if (!fechaExpValida)
            {
                lblExp.Show();
                lblExp.Text = "La fecha de expedición no es válida.";
                camposValidos = false;
            }
            else
            {
                lblExp.Hide();
            }

            bool formularioCompleto =
                camposValidos &&
                fechaExpCompleta &&
                fechaExpValida &&
                campoEst &&
                campoProd &&
                campoAct &&
                campoTiempo;

            if (formularioCompleto)
            {
                btnSolicitarProducto.Enabled = true;
                btnSolicitarProducto.BackColor = ColorTranslator.FromHtml("#5C69F5");
                lblDatosObligatorios.Hide();
            }
            else
            {
                btnSolicitarProducto.Enabled = false;
                btnSolicitarProducto.BackColor = Color.DimGray;
                lblDatosObligatorios.Visible = true;
            }
        }


        private bool ValidarCampoEspecifico(pLineaTextBox linea)
        {
            string texto = linea.TextBoxInterno.Text.Trim();

            bool valido = false;

            switch (linea.Name)
            {
                case "txtNombre":
                case "txtId":
                    valido = true;
                    break;

                case "txtCorreo":
                    valido = texto.Contains("@") && texto.Contains(".") && texto.Length >= 5;
                    break;

                case "txtDireccion":
                    valido = texto.Length >= 5;
                    break;

                case "txtTelefono":
                    valido = texto.Length == 10;
                    break;

                case "txtIngresos":
                case "txtEgresos":
                    valido = texto.Length >= 1 && !texto.StartsWith("0");
                    break;

                default:
                    valido = !string.IsNullOrWhiteSpace(texto);
                    break;
            }

            linea.BackColor = valido ? Color.FromArgb(0, 120, 215) : Color.FromArgb(220, 53, 69);

            return valido;
        }

        private void tabProductos_Enter(object sender, EventArgs e)
        {
            lblDatosObligatorios.Hide();
            lblExp.Hide();

            txtId.TextBoxInterno.Text = id_usuarioActual.ToString();
            txtNombre.TextBoxInterno.Text = nombre;

            DateTime fechaMinima = DateTime.Today.AddYears(-100);

            cmbExpAnio.Items.Clear();
            for (int anio = fechaMinima.Year; anio <= DateTime.Today.Year; anio++)
            {
                cmbExpAnio.Items.Add(anio.ToString());
            }

            int aux = 1;
            diccionarioMeses.Clear();
            foreach (string mes in cmbMes.Items)
            {
                diccionarioMeses.Add(mes, aux);
                aux++;
            }

            foreach (Control ctrl in tabProductos.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                    linea.TextBoxInterno.TextChanged += validarCmbSolicitud;
                }

                if (ctrl is System.Windows.Forms.ComboBox cmb)
                {
                    cmb.SelectedIndexChanged += fnc_validarCampos;
                    cmb.SelectedIndexChanged += validarCmbSolicitud;
                    cmb.SelectedValueChanged += validarCmbSolicitud;
                    cmb.SelectedValueChanged += fnc_validarCampos;
                }
            }
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

        private void tabProductos_Click(object sender, EventArgs e)
        {

        }

        private void pLineaTextBox5_Load(object sender, EventArgs e)
        {

        }

        private void cmbExpDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbExpMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbExpAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEstudios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void cmbActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNombre_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtId_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
