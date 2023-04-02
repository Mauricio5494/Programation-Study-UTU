
using System;
using System.Windows.Forms;

namespace Practico_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int contador = 0;

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            if (txtNinos.Text != "" && txtNinas.Text != "")
            {
                int resultado;
                int ninios = int.Parse(txtNinos.Text);
                int ninias = int.Parse(txtNinas.Text);


                resultado = ninios + ninias;

                labTotalIngresados.Text = ((ninios + ninias).ToString() + " Alumnos");
                labTotalHistorial.Text = ((ninios + ninias).ToString() + " Alumnos");

                double porcentajeNinios = (double)ninios / resultado * 100;
                double porcentajeNinias = (double)ninias / resultado * 100;
                int enterosSinResto = (int)Math.Floor(porcentajeNinios);
                int enterosSinResto2 = (int)Math.Floor(porcentajeNinias);

                string historial = enterosSinResto.ToString() + "%";
                string historial2 = enterosSinResto2.ToString() + "%";

                labNinosPorcentaje.Text = (enterosSinResto.ToString() + "%");
                labNinasPorcentaje.Text = (enterosSinResto2.ToString() + "%");
                labNinosHistorial.Text = (historial);
                labNinasHistorial.Text = (historial2);

                labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "Gracias por Usar Productos 'El Gori'";

            }
            else
            {
                MessageBox.Show("Por Favor, asegúrese de ingresar números en ambos campos.");
            }



        }

        private void txtNinos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnResetear_Click(object sender, System.EventArgs e)
        {
            labNinosPorcentaje.Text = "...";
            labNinasPorcentaje.Text = "...";
            labTotalIngresados.Text = "...";
            txtNinas.Text = "";
            txtNinos.Text = "";
            labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "Productos 'El Gori'";
        }

        private void btnResetHistorial_Click(object sender, System.EventArgs e)
        {
            labNinasHistorial.Text = "...";
            labNinosHistorial.Text = "...";
            labTotalHistorial.Text = "...";
        }

        private void labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular_Click(object sender, EventArgs e)
        {
            labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "¿Encerio le hiciste click?";
        }

        private void btnEasterEgg_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "AAAAAAAH ENCONTRASTE EL EASTEREGG!!!!!";

                var temporizador = new System.Windows.Forms.Timer();
                temporizador.Interval = 5000;
                temporizador.Tick += (s, args) =>
            {

                labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "Productos 'El Gori'";
                temporizador.Stop();


            };
                temporizador.Start();
                contador++;

            }
            else
            {
                labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "Bueno, basta, el easter egg ya pasó, deja de darle click";

                contador = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(x: 400, y: 150);
        }
    }
}
