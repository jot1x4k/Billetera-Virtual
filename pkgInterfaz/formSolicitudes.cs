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
        DateTime fechaExp;
        DateTime fechaNac;
        string cadenaFechaExp, cadenaFechaNac;
        bool campoEst;
        bool campoProd;

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
            campoEst = false;
            campoProd = false;

            campoEst = cmbEstudios.SelectedItem != null;
            campoProd = cmbProducto.SelectedItem != null;

            if (campoEst && campoProd)
            {
                lblEst.Hide();
                lblProd.Hide();

                btnSolicitarProducto.Enabled = true;
                btnSolicitarProducto.BackColor = Color.RoyalBlue;
            }
            else
            {
                btnSolicitarProducto.Enabled = campoEst && campoProd;
                btnSolicitarProducto.BackColor = Color.DimGray;
                lblEst.Visible = !campoEst;
                lblEst.Text = "Seleccione una opcion de la lista";
                lblProd.Visible = !campoProd;
                lblProd.Text = "Seleccione el producto que desea solicitar";
            }
        }


        private void btnSolicitarProducto_Click(object sender, EventArgs e)
        {

            string v_nombre = txtPNombre.TextBoxInterno.Text + " " + txtSNombre.TextBoxInterno.Text;
            string v_apellido = txtPApellido.TextBoxInterno.Text + " " + txtSApellido.TextBoxInterno.Text;
            string v_remitente = v_nombre + " " +  v_apellido;
            string v_fechaExp = cadenaFechaExp;
            string v_estudios = cmbEstudios.Text;
            string v_fechaNac = cadenaFechaNac;
            long v_telefono = long.Parse(txtTelefono.TextBoxInterno.Text);
            string v_correo = txtCorreo.TextBoxInterno.Text;
            long v_ingresos = long.Parse(txtIngresos.TextBoxInterno.Text);
            long v_egresos = long.Parse(txtEgresos.TextBoxInterno.Text);
            string v_producto = cmbProducto.Text;

            try
            {
                int resultadoDml = data.fnc_registrarProducto(v_remitente, id_usuarioActual, v_fechaExp, v_estudios, v_fechaNac, v_telefono, v_correo, v_ingresos, v_egresos, v_producto);
                if (resultadoDml > 0) 
                {
                    MessageBox.Show("Solicitud realizada con exito");
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
            bool fechaExpCompleta = !string.IsNullOrWhiteSpace(cmbExpDia.Text) &&
                                    !string.IsNullOrWhiteSpace(cmbExpMes.Text) &&
                                    !string.IsNullOrWhiteSpace(cmbExpAnio.Text);
            bool fechaNacCompleta = !string.IsNullOrWhiteSpace(cmbNacDia.Text) &&
                                    !string.IsNullOrWhiteSpace(cmbNacMes.Text) &&
                                    !string.IsNullOrWhiteSpace(cmbNacAnio.Text);

            foreach (Control ctrl in tabProductos.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    bool valido = ValidarCampoEspecifico(linea);
                    if (!valido) camposValidos = false;
                }
                if (ctrl is System.Windows.Forms.ComboBox cmb)
                {

                }
            }

            int mesExp, mesNac = 0;
            diccionarioMeses.TryGetValue(cmbExpMes.Text, out mesExp);
            cadenaFechaExp = $"{cmbExpDia.Text}/{mesExp}/{cmbExpAnio.Text}";
            bool fechaExpValida = DateTime.TryParseExact(
                cadenaFechaExp,
                "d/M/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaExp);

            diccionarioMeses.TryGetValue(cmbNacMes.Text, out mesNac);
            cadenaFechaNac = $"{cmbNacDia.Text}/{mesNac}/{cmbNacAnio.Text}";
            bool fechaNacValida = DateTime.TryParseExact(
                cadenaFechaNac,
                "d/M/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaNac) && fechaNac <= DateTime.Today.AddYears(-18);

            if (!fechaExpValida)
            {
                camposValidos = false;
                lblExp.Show();
                lblExp.Text = "La fecha de expedicion no es valida.";
            }
            else
            {
                lblExp.Show();
                lblExp.Text = "Fecha incompleta";
            }

            if (!fechaNacValida)
            {
                camposValidos = false;
                lblNac.Show();
                lblNac.Text = "La fecha de nacimiento no es valida.";
            }
            else
            {
                lblNac.Show();
                lblNac.Text = "Fecha incompleta";
            }

            if (camposValidos && fechaExpCompleta && fechaExpValida && fechaNacValida && fechaNacValida && campoEst && campoProd)
            {
                btnSolicitarProducto.Enabled = true;
                btnSolicitarProducto.BackColor = ColorTranslator.FromHtml("#5C69F5");
                lblDatosObligatorios.Hide();
                lblNac.Hide();
                lblExp.Hide();
            }
            else
            {
                btnSolicitarProducto.Enabled = false;
                btnSolicitarProducto.BackColor = Color.DimGray;

                lblDatosObligatorios.Visible = !camposValidos;
                lblExp.Visible = !fechaExpCompleta;
                lblNac.Visible = !fechaNacCompleta;
            }

            if (fechaExpCompleta && !fechaExpValida)
            {
                lblExp.Show();
                lblExp.Text = "La fecha de expedicion no es valida (Ej: dia no existe en el mes).";
            }
            if (fechaNacCompleta && !fechaNacValida)
            {
                lblNac.Show();
                lblNac.Text = "La fecha de nacimiento no es valida (Ej:, dia no existe en el mes, no es mayor de edad).";
            }
        }

        private bool ValidarCampoEspecifico(pLineaTextBox linea)
        {
            string texto = linea.TextBoxInterno.Text.Trim();

            bool valido = false;

            switch (linea.Name)
            {
                case "txtPNombre":
                case "txtPApellido":
                    valido = texto.All(char.IsLetter) && texto.Length > 1;
                    break;

                case "txtSNombre":
                case "txtSApellido":
                    valido = true; 
                    break;

                case "txtId":
                    valido = long.TryParse(texto, out _) && texto.Length >= 5;
                    break;

                case "txtCorreo":
                    valido = texto.Contains("@") && texto.Contains(".") && texto.Length >= 5;
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

            DateTime fechaMinima = DateTime.Today.AddYears(-100);

            cmbExpAnio.Items.Clear();
            cmbNacAnio.Items.Clear();
            for (int anio = fechaMinima.Year; anio <= DateTime.Today.Year; anio++)
            {
                cmbExpAnio.Items.Add(anio.ToString());
                cmbNacAnio.Items.Add(anio.ToString());
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

        private void cmbNacDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbNacMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbNacAnio_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
