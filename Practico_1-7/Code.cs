using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Practico_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNumero_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNumero.Text))
            {
                txbNumero.BackColor = Color.Red;
            }
            else
            {
                txbNumero.BackColor = Color.Black;
            }
        }

        private void txbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbNumero.Text))
                {
                    MessageBox.Show("EL campo está vacío, procure llenarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt64(txbNumero.Text) == 69)
                    {
                        switch (Convert.ToInt64(txbNumero.Text))
                        {
                            case 69:
                                labRes.Text = "No... No.";
                                break;
                        }

                    }
                    else
                    {
                        if (Convert.ToInt64(txbNumero.Text) == 0 || Convert.ToInt64(txbNumero.Text) > 12)
                        {
                            labRes.Text = "No es el número de un mes válido";
                        }
                        else
                        {
                            switch (Convert.ToInt64(txbNumero.Text))
                            {
                                case 1:
                                    labRes.Text = "Enero";
                                    break;

                                case 2:
                                    labRes.Text = "Febrero";
                                    break;
                                case 3:
                                    labRes.Text = "Marzo";
                                    break;
                                case 4:
                                    labRes.Text = "Abril";
                                    break;
                                case 5:
                                    labRes.Text = "Mayo";
                                    break;
                                case 6:
                                    labRes.Text = "Junio";
                                    break;
                                case 7:
                                    labRes.Text = "Julio";
                                    break;
                                case 8:
                                    labRes.Text = "Agosto";
                                    break;
                                case 9:
                                    labRes.Text = "Septiembre";
                                    break;
                                case 10:
                                    labRes.Text = "Octubre";
                                    break;
                                case 11:
                                    labRes.Text = "Noviembre";
                                    break;
                                case 12:
                                    labRes.Text = "Diciembre";
                                    break;
                            }
                        }




                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            labRes.Text = "...";
            txbNumero.Text = "";
        }
    }
}
