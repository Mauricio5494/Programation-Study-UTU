using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUnicoNumero.Text))
            {
                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUnicoNumero.BackColor = Color.Red;
            }
            else
            {
                int num = (int)Convert.ToInt64(txbUnicoNumero.Text);
                txbUnicoNumero.ForeColor = Color.White;
                txbUnicoNumero.BackColor = Color.Black;
                if (num == 0)
                {
                    labRes.Text = ("EL número no es par");
                    return;
                }
                if (num % 2 == 0)
                {
                    labRes.Text = ("El número es Par");
                }
                else
                {
                    labRes.Text = ("EL número es impar");
                }
            }



        }

        private void btnConsigna_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4. Realizar un programa que, dado un número entero, visualice en pantalla\r\nsi es par o impar. En el caso de ser 0, visualizar 'el número no es par ni\r\nimpar'.", "Consigna", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "No tenía ganas de meter tanta cosa en este programa.";
        }
    }
}
