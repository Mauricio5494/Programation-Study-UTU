using System;
using System.Drawing;
using System.Windows.Forms;

namespace práctico_1_1
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void primerNumeroTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(primerNumeroTextBox.Text))
            {
                primerNumeroTextBox.BackColor = Color.Red;
            }
            else
            {
                primerNumeroTextBox.BackColor = Color.Black;
            }
        }

        private void segundoNumeroTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(segundoNumeroTextBox.Text))
            {
                segundoNumeroTextBox.BackColor = Color.Red;
            }
            else
            {
                segundoNumeroTextBox.BackColor = Color.Black;
            }
        }

        private void tercerNumeroTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tercerNumeroTextBox.Text))
            {
                tercerNumeroTextBox.BackColor = Color.Red;
            }
            else
            {
                tercerNumeroTextBox.BackColor = Color.Black;
            }
        }

        private void cuartonumeroTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cuartonumeroTextBox.Text))
            {
                cuartonumeroTextBox.BackColor = Color.Red;
            }
            else
            {
                cuartonumeroTextBox.BackColor = Color.Black;
            }
        }

        private void calcularPromedioButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(primerNumeroTextBox.Text) || string.IsNullOrEmpty(segundoNumeroTextBox.Text) || string.IsNullOrEmpty(tercerNumeroTextBox.Text) || string.IsNullOrEmpty(cuartonumeroTextBox.Text))
                {

                    MessageBox.Show("Hay campos vacíos, llene cada uno de ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    primerNumeroTextBox.BackColor = ((Color)Color.Black);
                    segundoNumeroTextBox.BackColor = ((Color)Color.Black);
                    tercerNumeroTextBox.BackColor = ((Color)Color.Black);
                    cuartonumeroTextBox.BackColor = Color.Black;

                    String historialUltimoPromedio = primerNumeroTextBox.Text + ", " + segundoNumeroTextBox.Text + ", " + tercerNumeroTextBox.Text + ", " + cuartonumeroTextBox.Text;
                    numerosIngresadosLabel.Text = historialUltimoPromedio;


                    double num1 = Double.Parse(primerNumeroTextBox.Text);
                    double num2 = Double.Parse(segundoNumeroTextBox.Text);
                    double num3 = Double.Parse(tercerNumeroTextBox.Text);
                    double num4 = Double.Parse(cuartonumeroTextBox.Text);


                    double promedio = (num1 + num2 + num3 + num4) / 4;
                    promedioLabel.Text = promedio.ToString();
                    ultimoPromedioLabel.Text = promedio.ToString();
                }
            }
            else
            {
                return;
            }

        }

        private void resetButon_Click(object sender, EventArgs e)
        {
            primerNumeroTextBox.Text = "";
            segundoNumeroTextBox.Text = "";
            tercerNumeroTextBox.Text = "";
            cuartonumeroTextBox.Text = "";
            promedioLabel.Text = "...";
        }



        private void primerNumeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void segundoNumeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled= true;
            }
        }

        private void tercerNumeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cuartonumeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
