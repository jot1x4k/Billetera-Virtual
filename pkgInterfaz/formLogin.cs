using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;
using testForms.pkgInterfaz;
using testForms.pkgLogica;
using static System.Net.Mime.MediaTypeNames;

namespace testForms
{
    public partial class formLogin : Form
    {
        Datos data = new Datos();
        bool usuarioCorrecto = true;
        bool claveCorrecta = true;
        public formLogin()
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this);
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            lblErrorClave.Hide();
            lblErrorUsuario.Hide();

            txtClave.esClave = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                }
            }

            btnIniciarSesion.Click += fnc_validarCampos;
        }
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            usuarioCorrecto = true;
            claveCorrecta = true;
            Color colorExito = ColorTranslator.FromHtml("#5C69F5"); // Azul
            Color colorError = ColorTranslator.FromHtml("#F24822"); // Rojo

            usuarioCorrecto = !string.IsNullOrEmpty(txtUsuario.TextBoxInterno.Text);
            claveCorrecta = !string.IsNullOrEmpty(txtClave.TextBoxInterno.Text);

            if (usuarioCorrecto)
            {
                lblErrorUsuario.Hide();
                txtUsuario.BackColor = colorExito;
            }
            else
            {
                lblErrorUsuario.Show();
                txtUsuario.BackColor = colorError;
            }

            if (claveCorrecta)
            {
                lblErrorClave.Hide();
                txtClave.BackColor = colorExito;
            }
            else
            {
                lblErrorClave.Show();
                txtClave.BackColor = colorError;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formRegistro frmReg = new formRegistro(this))
            {
                frmReg.ShowDialog();
                this.Hide();
            }

            this.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.TextBoxInterno.Text;
            string clave = txtClave.TextBoxInterno.Text;
            long idUsuario = 0;

            Usuario u = new Usuario();
            idUsuario = u.fnc_loginUsuario(usuario, clave);

            if (idUsuario > 0)
            {
                if(u.fnc_verificarAdmin(idUsuario) == "admin")
                {
                    using (var frmHomeAdmin = new formHomeAdmin())
                    {
                        frmHomeAdmin.ShowDialog();
                        this.Hide();
                    }
                    this.Show();
                }
                else
                {
                    this.Hide();
                    using (var frmHome = new formHomeCliente(idUsuario))
                    {
                        frmHome.ShowDialog();
                    }
                    this.Show();
                }
                     
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtUsuario.TextBoxInterno.Text = default;
                txtClave.TextBoxInterno.Text = default;
            }
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

        private void pBoton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
