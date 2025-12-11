using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    public partial class formComprobante : Form
    {
        string referencia;
        public formComprobante(int prm_destino, int prm_monto, DateTime prm_fecha, int prm_referencia)
        {
            InitializeComponent();
            FormHelper.HabilitarMovimiento(this, pDegradado1);
            lblCuentaDestino.Text = prm_destino.ToString();
            lblMonto.Text = prm_monto.ToString("C2");
            lblFecha.Text = prm_fecha.ToString("G");
            lblReferencia.Text = prm_referencia.ToString();
            referencia = prm_referencia.ToString();
        }

        public string ObtenerRutaEscritorio()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            return rutaEscritorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaEscritorio = ObtenerRutaEscritorio();

                string nombreCarpeta = "Documentos - Banco de los Andes";

                string rutaCarpetaCompleta = Path.Combine(rutaEscritorio, nombreCarpeta);

                if (!Directory.Exists(rutaCarpetaCompleta))
                {
                    Directory.CreateDirectory(rutaCarpetaCompleta);
                }

                string nombreArchivo = $"Comprobante_{referencia}.png";

                string rutaCompletaArchivo = Path.Combine(rutaCarpetaCompleta, nombreArchivo);

                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    button1.Hide();
                    pBoton1.Hide();
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

                    bmp.Save(rutaCompletaArchivo, ImageFormat.Png);

                    MessageBox.Show("Referencia guardada exitosamente en:\n" + rutaCompletaArchivo,
                                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la referencia:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pBoton1.Show();
        }

        private void pBoton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
