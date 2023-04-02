namespace Practico_1_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.imgbPoroOldPhoto = new System.Windows.Forms.Label();
            this.txbAñoViciestoOno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(71, 147);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // imgbPoroOldPhoto
            // 
            this.imgbPoroOldPhoto.AutoSize = true;
            this.imgbPoroOldPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgbPoroOldPhoto.Location = new System.Drawing.Point(68, 96);
            this.imgbPoroOldPhoto.Name = "imgbPoroOldPhoto";
            this.imgbPoroOldPhoto.Size = new System.Drawing.Size(82, 13);
            this.imgbPoroOldPhoto.TabIndex = 1;
            this.imgbPoroOldPhoto.Text = "Número del año";
            // 
            // txbAñoViciestoOno
            // 
            this.txbAñoViciestoOno.BackColor = System.Drawing.Color.Black;
            this.txbAñoViciestoOno.ForeColor = System.Drawing.Color.White;
            this.txbAñoViciestoOno.Location = new System.Drawing.Point(68, 112);
            this.txbAñoViciestoOno.Name = "txbAñoViciestoOno";
            this.txbAñoViciestoOno.Size = new System.Drawing.Size(100, 20);
            this.txbAñoViciestoOno.TabIndex = 2;
            this.txbAñoViciestoOno.Validating += new System.ComponentModel.CancelEventHandler(this.txbAñoViciestoOno_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos \'El Gori\'";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(212, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labRes.Location = new System.Drawing.Point(276, 147);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(16, 13);
            this.labRes.TabIndex = 6;
            this.labRes.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Practico_1_5.Properties.Resources.Screenshot_65;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Practico_1_5.Properties.Resources.Screenshot_65;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 286);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAñoViciestoOno);
            this.Controls.Add(this.imgbPoroOldPhoto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Calendario Gregoriano Viciesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label imgbPoroOldPhoto;
        private System.Windows.Forms.TextBox txbAñoViciestoOno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

