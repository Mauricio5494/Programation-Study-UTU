using System;
using System.Windows.Forms;

namespace Practico1_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intentos;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txbClave.Text == "eureka")
            {
                Close();
            }
            else
            {
                intentos++;
                if (intentos == 3)
                {
                    MessageBox.Show("Agotaste tus intentos, vuelve a intentar más tarde", "Inicio de Sesión Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    int intentosRestantes = 3 - intentos;
                    label3.Text = "" + (intentosRestantes);
                }
                txbClave.Clear();
            }
        }
    }
}
