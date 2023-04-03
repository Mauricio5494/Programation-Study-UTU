using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNumero.Text))
            {
                txbNumero.BackColor = Color.Red;
            }
            else
            {
                txbNumero.BackColor = Color.White;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbNumero.Text))
                {
                    MessageBox.Show("El campo está vacío, procure llenarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (radbtnOctubreOFF.Checked)
                    {
                        double importeDeCompra = double.Parse(txbNumero.Text);
                        double descuento = 0.0;
                        double totalDeLaCompra = 0.0;

                        descuento = importeDeCompra * 0.15;
                        totalDeLaCompra = importeDeCompra - descuento;


                        labDescuentoTotal.Text = ("$" + totalDeLaCompra.ToString());
                        labTotal.Text = ("$" + txbNumero.Text);
                        labDescuentoTotal.ForeColor = Color.Green;
                        txbNumero.BackColor = Color.Black;

                    }
                    else
                    {

                        labTotal.Text = ("$" + txbNumero.Text);
                        labDescuentoTotal.Text = "No aplica";
                        labDescuentoTotal.ForeColor = Color.Red;
                        txbNumero.BackColor = Color.Black;
                    }
                }
            }
        }




    }
}
