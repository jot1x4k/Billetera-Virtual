using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using testForms.pkgBaseDatos;
using testForms.pkgInterfaz;

namespace testForms
{
    public partial class formRegistro : Form
    {
        formLogin frmLogin = new formLogin();
        DateTime fechaNacimiento;
        Datos data = new Datos();
        static Dictionary<string, int> diccionarioMeses = new Dictionary<string, int>();

        public formRegistro()
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado1);
        }

        public formRegistro(formLogin login)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado1);
            frmLogin = login;
            btnRegistrar.BackColor = Color.DimGray;
        }

        private void formRegistro_Load(object sender, EventArgs e)
        {
            lblDatosObligatorios.Hide();
            lblClaveUsuario.Hide();
            lblFechaIncompleta.Hide();

            DateTime fechaMaxima = DateTime.Today;
            DateTime fechaMinima = DateTime.Today.AddYears(-100);

            cmbAnio.Items.Clear();
            for (int anio = fechaMinima.Year; anio <= fechaMaxima.Year; anio++)
            {
                cmbAnio.Items.Add(anio.ToString());
            }

            int aux = 1;
            diccionarioMeses.Clear();
            foreach (string mes in cmbMes.Items)
            {
                diccionarioMeses.Add(mes, aux);
                aux++;
            }

            txtClave.esClave = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                }

                if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedValueChanged += fnc_validarCampos;
                }
            }
        }

        private bool ValidarCampoEspecifico(pLineaTextBox linea)
        {
            string texto = linea.TextBoxInterno.Text.Trim();

            bool valido = false;

            switch (linea.Name)
            {
                case "txtPrimerNombre":
                case "txtPrimerApellido":
                    valido = texto.All(char.IsLetter) && texto.Length > 1;
                    break;

                case "txtId":
                    valido = long.TryParse(texto, out _) && texto.Length >= 5;
                    break;

                case "txtCorreo":
                    valido = texto.Contains("@") && texto.Contains(".");
                    break;

                case "txtUsuario":
                    valido = texto.Length >= 4;
                    break;

                case "txtClave":
                    valido = texto.Length >= 6 && !string.Equals(texto, txtUsuario.TextBoxInterno.Text, StringComparison.OrdinalIgnoreCase);
                    lblClaveUsuario.Visible = !valido && texto == txtUsuario.TextBoxInterno.Text;
                    break;

                default:
                    valido = !string.IsNullOrWhiteSpace(texto);
                    break;
            }

            linea.BackColor = valido ? Color.FromArgb(0, 120, 215) : Color.FromArgb(220, 53, 69);

            return valido;
        }

        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool camposValidos = true;
            bool fechaCompleta = !string.IsNullOrWhiteSpace(cmbDia.Text) &&
                                 !string.IsNullOrWhiteSpace(cmbMes.Text) &&
                                 !string.IsNullOrWhiteSpace(cmbAnio.Text);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    bool valido = ValidarCampoEspecifico(linea);
                    if (!valido) camposValidos = false;
                }
            }

            int mes = 0;
            diccionarioMeses.TryGetValue(cmbMes.Text, out mes);
            string cadenaFecha = $"{cmbDia.Text}/{mes}/{cmbAnio.Text}";

            bool fechaValida = DateTime.TryParseExact(
                cadenaFecha,
                "d/M/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaNacimiento) && fechaNacimiento <= DateTime.Today.AddYears(-18);

            if (!fechaValida)
            {
                camposValidos = false;
                lblFechaIncompleta.Show();
                lblFechaIncompleta.Text = "La fecha no es valida (dia no existe en el mes).";
            }
            if (!fechaCompleta)
            {
                camposValidos = false;
                lblFechaIncompleta.Show();
                lblFechaIncompleta.Text = "La fecha esta incompleta";
            }

            if (camposValidos && fechaCompleta && fechaValida)
            {
                btnRegistrar.Enabled = true;
                btnRegistrar.BackColor = ColorTranslator.FromHtml("#5C69F5");
                lblDatosObligatorios.Hide();
                lblFechaIncompleta.Hide();
            }
            else
            {
                btnRegistrar.Enabled = false;
                btnRegistrar.BackColor = Color.DimGray;

                lblDatosObligatorios.Visible = !camposValidos;
                lblFechaIncompleta.Visible = !fechaCompleta;
            }

            if(fechaCompleta && !fechaValida)
            {
                lblFechaIncompleta.Show();
                lblFechaIncompleta.Text = "La fecha no es valida (Debes ser mayor de edad).";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!btnRegistrar.Enabled)
            {
                MessageBox.Show("Por favor corrija los campos marcados antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string v_nombre = txtPrimerNombre.TextBoxInterno.Text + " " + txtPrimerApellido.TextBoxInterno.Text;
                string v_mail = txtCorreo.TextBoxInterno.Text;
                long v_id = long.Parse(txtId.TextBoxInterno.Text);
                string v_usuario = txtUsuario.TextBoxInterno.Text;
                string v_clave = txtClave.TextBoxInterno.Text;
                string v_fechaNac = fechaNacimiento.ToString();

                int resultadoDml = data.fnc_registrarUsuario(v_nombre, v_mail, v_id, v_usuario, v_clave, v_fechaNac);

                switch (resultadoDml)
                {
                    case 1:
                        MessageBox.Show("Registro completado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case -1:
                        MessageBox.Show("Ya existe una cuenta registrada con el ID que ingreso", "Registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -2:
                        MessageBox.Show("Ya existe una cuenta registrada con el correo que ingreso", "Registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -3:
                        MessageBox.Show("Ya existe una cuenta registrada con el usuario que ingreso", "Registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show("No se pudo completar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los campos requeridos contienen datos inválidos",
                                "Error al registrarse",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                Console.WriteLine(ex);
            }
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMostrarClave_Click(object sender, EventArgs e)
        {
            txtClave.esClave = false;

            picMostrarClave.Hide();
            picMostrarClave.Enabled = false;

            picOcultarClave.Show();
            picOcultarClave.Enabled = true;
        }

        private void picOcultarClave_Click(object sender, EventArgs e)
        {
            txtClave.esClave = true;

            picOcultarClave.Hide();
            picOcultarClave.Enabled = false;

            picMostrarClave.Show();
            picMostrarClave.Enabled = true;
        }

        private void pBoton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmbDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
