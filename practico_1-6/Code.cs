using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNumN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNumN.Text))
            {
                txbNumN.BackColor = Color.Red;
            }
            else
            {
                txbNumN.BackColor = Color.Black;
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbNumN.Text))
                {
                    MessageBox.Show("El campo está vacío, Procure llenarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(txbNumN.Text, out int n))
                    {
                        int suma = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            suma += i;
                        }
                        labRes.Text = $"La suma de los primeros {n} números naturales es {suma}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un número entero válido para N", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }


    }
}

