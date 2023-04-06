using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txbNumeros_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNumeros.Text))
            {
                txbNumeros.BackColor = Color.Red;
            }
            else
            {
                txbNumeros.BackColor = Color.Black;
            }
        }

        private void txbNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbNumeros.Text))
                {
                    MessageBox.Show("El campo está vacío, por favor procure llenarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToUInt64(txbNumeros.Text) >= 4294967295)
                    {
                        MessageBox.Show("Por Favor ingrese un número entre 0 y 4.294.967.295", "Número Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        int num = (int)Convert.ToInt64(txbNumeros.Text);

                        if (num == 0)
                        {
                            MessageBox.Show("La suma total es: " + sumLstBox(Lista_De_Resultados), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txbNumeros.Clear();
                            return;
                        }
                        Lista_De_Resultados.Items.Add(num);
                        txbNumeros.Clear();
                    }

                }

            }

        }

        private int sumLstBox(ListBox Lista_De_Resultados)
        {
            int suma = 0;

            foreach (var item in Lista_De_Resultados.Items)
            {
                suma += (int)Convert.ToInt64(item);
            }

            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Lista_De_Resultados.Items.Count == 0)
            {
                MessageBox.Show("No hay Items que eliminar de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Lista_De_Resultados.Items.Clear();
            }

        }
    }
}
