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
    public partial class formActualizarCliente : Form
    {

        long id_usuarioActual = 0;
        string clave;
        Datos data = new Datos();

        public formActualizarCliente()
        {
            InitializeComponent();
        }
        public formActualizarCliente(long prm_usuarioActual)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado3);
            id_usuarioActual = prm_usuarioActual;

            var infoCliente = data.fnc_obtenerInfoCliente(prm_usuarioActual);

            txtCorreo.placeholder = infoCliente.Value.mail;
            txtUsuario.placeholder = infoCliente.Value.usuario;
            clave = infoCliente.Value.clave;

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

            txtClaveNueva.Hide();

            txtClaveActual.esClave = true;
            txtClaveNueva.esClave = true;

            picMostrarClaveNueva.Hide();
            picOcultarClaveNueva.Hide();
        }

        private bool ValidarCampoEspecifico(pLineaTextBox linea)
        {
            string texto = linea.TextBoxInterno.Text.Trim();
            bool valido = false;

            if (linea.Name == "txtCorreo") lblCorreoInvalido.Visible = false;
            if (linea.Name == "txtUsuario") lblUsuarioInvalido.Visible = false;
            if (linea.Name == "txtClaveNueva") lblClaveInvalida.Visible = false;

            switch (linea.Name)
            {
                case "txtCorreo":
                    valido = texto.Contains("@") && texto.Contains(".") &&
                             !string.Equals(texto, txtCorreo.TextBoxInterno.PlaceHolder);
                    lblCorreoInvalido.Visible = !valido && texto.Length > 0;

                    break;

                case "txtUsuario":
                    valido = texto.Length >= 4 &&
                             !string.Equals(texto, txtUsuario.TextBoxInterno.PlaceHolder);
                    lblUsuarioInvalido.Visible = !valido && texto.Length > 0;
                    break;

                case "txtClaveNueva":
                    valido = texto.Length >= 6 &&
                             !string.Equals(texto, txtClaveActual.TextBoxInterno.Text, StringComparison.OrdinalIgnoreCase);
                    lblClaveInvalida.Visible = !valido && texto.Length > 0;

                    break;

                case "txtClaveActual":
                    valido = string.Equals(texto, clave);
                    txtClaveNueva.Enabled = valido;
                    txtClaveNueva.Visible = valido;
                    picMostrarClaveNueva.Visible = valido;

                    break;

                default:
                    valido = !string.IsNullOrWhiteSpace(texto);
                    break;
            }

            return valido;
        }


        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool algunCambio = false;
            bool camposValidos = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    string texto = linea.TextBoxInterno.Text.Trim();
                    string original = linea.TextBoxInterno.PlaceHolder;

                    bool valido = ValidarCampoEspecifico(linea);

                    if (linea.Name != "txtClaveActual")
                    {
                        if (!string.IsNullOrEmpty(texto) && texto != original)
                        {
                            algunCambio = true;
                            if (!valido)
                                camposValidos = false;
                        }
                    }
                    else
                    {
                        if (!valido)
                            camposValidos = false;
                    }
                }
            }

            btnGuardar.Enabled = algunCambio && camposValidos;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picOcultarClaveActual_Click(object sender, EventArgs e)
        {
            txtClaveActual.esClave = true;

            picOcultarClaveActual.Hide();
            picOcultarClaveActual.Enabled = false;

            picMostrarClaveActual.Show();
            picMostrarClaveActual.Enabled = true;
        }

        private void picMostrarClaveActual_Click(object sender, EventArgs e)
        {
            txtClaveActual.esClave = false;

            picMostrarClaveActual.Hide();
            picMostrarClaveActual.Enabled = false;

            picOcultarClaveActual.Show();
            picOcultarClaveActual.Enabled = true;
        }

        private void picOcultarClaveNueva_Click(object sender, EventArgs e)
        {
            txtClaveNueva.esClave = true;

            picOcultarClaveNueva.Hide();
            picOcultarClaveNueva.Enabled = false;

            picMostrarClaveNueva.Show();
            picMostrarClaveNueva.Enabled = true;
        }

        private void picMostrarClaveNueva_Click(object sender, EventArgs e)
        {
            txtClaveNueva.esClave = false;

            picMostrarClaveNueva.Hide();
            picMostrarClaveNueva.Enabled = false;

            picOcultarClaveNueva.Show();
            picOcultarClaveNueva.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtUsuario.TextBoxInterno.Text.Trim();
            string nuevoCorreo = txtCorreo.TextBoxInterno.Text.Trim();
            string nuevaClave = txtClaveNueva.TextBoxInterno.Text.Trim();

            string usuarioFinal = string.IsNullOrEmpty(nuevoUsuario) ? txtUsuario.placeholder : nuevoUsuario;
            string correoFinal = string.IsNullOrEmpty(nuevoCorreo) ? txtCorreo.placeholder : nuevoCorreo;
            string claveFinal = string.IsNullOrEmpty(nuevaClave) ? clave : nuevaClave;

            int resultado = data.fnc_actualizarInfoCliente(id_usuarioActual, correoFinal, usuarioFinal, claveFinal);

            if (resultado == 0)
            {
                MessageBox.Show("Los datos ingresados ya están asociados a otra cuenta.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Información actualizada correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
