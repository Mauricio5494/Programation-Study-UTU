namespace practico_1_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbSegundoNum = new System.Windows.Forms.TextBox();
            this.txbPrimerNum = new System.Windows.Forms.TextBox();
            this.txbTercerNum = new System.Windows.Forms.TextBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labEasterEgg = new System.Windows.Forms.Label();
            this.labElCreadoryYaEsta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(109, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Números";
            // 
            // txbSegundoNum
            // 
            this.txbSegundoNum.BackColor = System.Drawing.Color.Black;
            this.txbSegundoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSegundoNum.ForeColor = System.Drawing.Color.White;
            this.txbSegundoNum.Location = new System.Drawing.Point(109, 118);
            this.txbSegundoNum.Name = "txbSegundoNum";
            this.txbSegundoNum.Size = new System.Drawing.Size(100, 20);
            this.txbSegundoNum.TabIndex = 2;
            this.txbSegundoNum.TextChanged += new System.EventHandler(this.txbSegundoNum_TextChanged);
            this.txbSegundoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSegundoNum_KeyPress);
            this.txbSegundoNum.Validating += new System.ComponentModel.CancelEventHandler(this.txbSegundoNum_Validating);
            // 
            // txbPrimerNum
            // 
            this.txbPrimerNum.BackColor = System.Drawing.Color.Black;
            this.txbPrimerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrimerNum.ForeColor = System.Drawing.Color.White;
            this.txbPrimerNum.Location = new System.Drawing.Point(109, 78);
            this.txbPrimerNum.Name = "txbPrimerNum";
            this.txbPrimerNum.Size = new System.Drawing.Size(100, 20);
            this.txbPrimerNum.TabIndex = 3;
            this.txbPrimerNum.TextChanged += new System.EventHandler(this.txbPrimerNum_TextChanged);
            this.txbPrimerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNum_KeyPress);
            this.txbPrimerNum.Validating += new System.ComponentModel.CancelEventHandler(this.txbPrimerNum_Validating);
            // 
            // txbTercerNum
            // 
            this.txbTercerNum.BackColor = System.Drawing.Color.Black;
            this.txbTercerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTercerNum.ForeColor = System.Drawing.Color.White;
            this.txbTercerNum.Location = new System.Drawing.Point(109, 159);
            this.txbTercerNum.Name = "txbTercerNum";
            this.txbTercerNum.Size = new System.Drawing.Size(100, 20);
            this.txbTercerNum.TabIndex = 4;
            this.txbTercerNum.TextChanged += new System.EventHandler(this.txbTercerNum_TextChanged);
            this.txbTercerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTercerNum_KeyPress);
            this.txbTercerNum.Validating += new System.ComponentModel.CancelEventHandler(this.txbTercerNum_Validating);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(324, 125);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(16, 13);
            this.labResultado.TabIndex = 5;
            this.labResultado.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(215, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(215, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(215, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Los campos con";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "no pueden estar vacíos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(204, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labEasterEgg
            // 
            this.labEasterEgg.AutoSize = true;
            this.labEasterEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEasterEgg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labEasterEgg.Location = new System.Drawing.Point(470, 9);
            this.labEasterEgg.Name = "labEasterEgg";
            this.labEasterEgg.Size = new System.Drawing.Size(10, 13);
            this.labEasterEgg.TabIndex = 13;
            this.labEasterEgg.Text = ".";
            // 
            // labElCreadoryYaEsta
            // 
            this.labElCreadoryYaEsta.AutoSize = true;
            this.labElCreadoryYaEsta.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labElCreadoryYaEsta.Location = new System.Drawing.Point(180, 343);
            this.labElCreadoryYaEsta.Name = "labElCreadoryYaEsta";
            this.labElCreadoryYaEsta.Size = new System.Drawing.Size(118, 17);
            this.labElCreadoryYaEsta.TabIndex = 14;
            this.labElCreadoryYaEsta.Text = "Productos \"El Gori\"";
            this.labElCreadoryYaEsta.Click += new System.EventHandler(this.labElCreadoryYaEsta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(109, 226);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 369);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labElCreadoryYaEsta);
            this.Controls.Add(this.labEasterEgg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.txbTercerNum);
            this.Controls.Add(this.txbPrimerNum);
            this.Controls.Add(this.txbSegundoNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LA 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSegundoNum;
        private System.Windows.Forms.TextBox txbPrimerNum;
        private System.Windows.Forms.TextBox txbTercerNum;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labEasterEgg;
        private System.Windows.Forms.Label labElCreadoryYaEsta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrar;
    }
}

