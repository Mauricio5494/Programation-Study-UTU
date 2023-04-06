using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void txbEdad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEdad.Text))
            {
                txbEdad.BackColor = Color.Red;
            }
            else
            {
                txbEdad.BackColor = Color.Black;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbEdad.Text) || string.IsNullOrWhiteSpace(txbEdad.Text))
                {
                    MessageBox.Show("El campo está vacío, procure llenarlo antes de proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int edad;
                    bool respuesta = int.TryParse(txbEdad.Text, out edad);

                    if (!respuesta)
                    {
                        MessageBox.Show("Tiene que ingresar una edad válida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (radioButtonATP.Checked || (radioButtonP9.Checked && edad >= 9) || (radioButtonP12_1.Checked && edad >= 12 || radioButtonP12_2.Checked && edad >= 12) || (radioButtonP15_1.Checked && edad >= 15 || radioButtonP15_2.Checked && edad >= 15 || radioButtonP15_3.Checked && edad >= 15) || (radioButtonP18.Checked && edad >= 18))
                    {
                        labSentenciaRes.Text = "Puede entrar a la Sala";
                        labSentenciaRes.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        labSentenciaRes.Text = "No tiene la edad mínima requerida para ver esta película.";
                        labSentenciaRes.ForeColor = Color.DarkRed;
                    }
                }




            }
        }
    }
}
