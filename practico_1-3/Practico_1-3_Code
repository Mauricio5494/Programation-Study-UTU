using System;
using System.Drawing;
using System.Windows.Forms;

namespace practico_1_3
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int contador = 0;
        public ToolTip tip = new ToolTip();

        private void txbPrimerNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbPrimerNum.Text))
            {

                txbPrimerNum.BackColor = Color.Red;
                tip.SetToolTip(txbPrimerNum, "Obligatorio llenar el campo");
            }
            else
            {

                txbPrimerNum.BackColor = Color.Black;
            }
        }

        private void txbSegundoNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbSegundoNum.Text))
            {

                txbSegundoNum.BackColor = Color.Red;
                tip.SetToolTip(txbSegundoNum, "Obligatorio llenar el campo");
            }
            else
            {
                txbSegundoNum.BackColor = Color.Black;
            }
        }

        private void txbTercerNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTercerNum.Text))
            {
                txbTercerNum.BackColor = Color.Red;
                tip.SetToolTip(txbTercerNum, "Obligatorio llenar el campo");
            }
            else
            {
                txbTercerNum.BackColor = Color.Black;
            }
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbPrimerNum.Text) || string.IsNullOrEmpty(txbSegundoNum.Text) || string.IsNullOrEmpty(txbTercerNum.Text))
                {
                    MessageBox.Show("Por favor, llene todos los campos marcados en rojo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double num1, num2, num3;

                if (!double.TryParse(txbPrimerNum.Text, out num1) || !double.TryParse(txbSegundoNum.Text, out num2) || !double.TryParse(txbTercerNum.Text, out num3))
                {
                    MessageBox.Show("Por favor ingrese solo números válidos en los campos.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (num1 < 0)
                {
                    double res = num1 * num2 * num3;
                    labResultado.Text = res.ToString();
                }
                else
                {
                    double res = num1 + num2 + num3;
                    labResultado.Text = res.ToString();
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txbPrimerNum.Text = "";
            txbPrimerNum.BackColor = Color.Black;
            txbSegundoNum.Text = "";
            txbSegundoNum.BackColor = Color.Black;
            txbTercerNum.Text = "";
            txbTercerNum.BackColor = Color.Black;
            labResultado.Text = "...";


        }

        private void txbPrimerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txbSegundoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txbTercerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txbPrimerNum_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPrimerNum.Text))
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void txbSegundoNum_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSegundoNum.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void txbTercerNum_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTercerNum.Text))
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ToolTip hint = new ToolTip();
            hint.SetToolTip(label3, "Campo obligatorio");
            hint.SetToolTip(label4, "Campo olbigatorio");
            hint.SetToolTip(label5, "Campo obligatorio");
            hint.SetToolTip(btnCalcular, "Calcula los 3 numeros ingresados");
            hint.SetToolTip(labEasterEgg, "hmm... Parece ser que alguien ya descubrió que me gusta meter estas cosas en mis programitas\nPero lo lamento, esto es todo lo que hay en este.");
            hint.SetToolTip(labElCreadoryYaEsta, "No, no pasará nada si apretas click");

            hint.Active = true;



        }

        private void labElCreadoryYaEsta_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                labElCreadoryYaEsta.Text = "O quizás si?";

                var temporizador = new System.Windows.Forms.Timer();
                temporizador.Interval = 5000;
                temporizador.Tick += (s, args) =>
                {

                    labElCreadoryYaEsta.Text = "Productos 'El Gori'";
                    temporizador.Stop();


                };
                temporizador.Start();
                contador++;

            }
            else
            {
                contador = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consigna:\nIdear una aplicación que solicite el ingreso de tres números; si el primero\r\nes negativo, debe mostrar el producto de los tres, y si no lo es, mostrará\r\nla suma.");
        }


    }
}
