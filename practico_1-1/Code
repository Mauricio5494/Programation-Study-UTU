using System;
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
            this.SetDesktopLocation(x: 450, y: 145);
        }

        private void calcularPromedioButton_Click(object sender, EventArgs e)
        {

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

        private void resetButon_Click(object sender, EventArgs e)
        {
            primerNumeroTextBox.Text = "";
            segundoNumeroTextBox.Text = "";
            tercerNumeroTextBox.Text = "";
            cuartonumeroTextBox.Text = "";
            promedioLabel.Text = "...";
        }


    }
}
