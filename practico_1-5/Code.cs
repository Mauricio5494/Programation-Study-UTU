using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Practico_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ToolTip hint = new ToolTip();
        public int año;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = AjustarOpacidad(pictureBox1.Image, 0.7f);
            hint.SetToolTip(pictureBox2, "Un lindo recuerdo.... Bueno, no.");
        }

        public static Bitmap AjustarOpacidad(System.Drawing.Image image, float opacidad)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            Graphics g = Graphics.FromImage(bmp);

            ColorMatrix colorM = new ColorMatrix();
            colorM.Matrix33 = opacidad;

            ImageAttributes imgAtr = new ImageAttributes();
            imgAtr.SetColorMatrix(colorM, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAtr);

            return bmp;
        }

        private void txbAñoViciestoOno_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbAñoViciestoOno.Text))
            {
                txbAñoViciestoOno.BackColor = Color.Red;
            }
            else
            {
                txbAñoViciestoOno.BackColor = Color.Black;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (string.IsNullOrEmpty(txbAñoViciestoOno.Text))
                {
                    MessageBox.Show("El campo está vacío, procure llenarlo antes de proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    if (Convert.ToInt64(txbAñoViciestoOno.Text) >= 4294967295)
                    {
                        MessageBox.Show("Por favor, ponga un número entre 0 y 4.294.967.295", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        

                        if ((año % 4 == 0 && año % 100 != 0) || año % 400 == 0)
                        {
                            labRes.Text = "Es un año Biciesto";
                        }
                        else
                        {
                            labRes.Text = "No es un año Biciesto";
                        }
                    }

                }


            }

        }




    }
}
