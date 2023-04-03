namespace Practico_1_8
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radbtnOctubreOFF = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Enero = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDescuentoTotal = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(67, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculcar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(71, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de la Compra";
            // 
            // txbNumero
            // 
            this.txbNumero.BackColor = System.Drawing.Color.Black;
            this.txbNumero.ForeColor = System.Drawing.Color.White;
            this.txbNumero.Location = new System.Drawing.Point(67, 81);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 2;
            this.txbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txbNumero.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Controls.Add(this.radbtnOctubreOFF);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Enero);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(221, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes del Año";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton10.Location = new System.Drawing.Point(158, 78);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(72, 17);
            this.radioButton10.TabIndex = 10;
            this.radioButton10.Text = "Diciembre";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton11.Location = new System.Drawing.Point(158, 55);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(76, 17);
            this.radioButton11.TabIndex = 9;
            this.radioButton11.Text = "Noviembre";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radbtnOctubreOFF
            // 
            this.radbtnOctubreOFF.AutoSize = true;
            this.radbtnOctubreOFF.ForeColor = System.Drawing.Color.Transparent;
            this.radbtnOctubreOFF.Location = new System.Drawing.Point(158, 32);
            this.radbtnOctubreOFF.Name = "radbtnOctubreOFF";
            this.radbtnOctubreOFF.Size = new System.Drawing.Size(106, 17);
            this.radbtnOctubreOFF.TabIndex = 8;
            this.radbtnOctubreOFF.Text = "Octubre -15% Off";
            this.radbtnOctubreOFF.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton5.Location = new System.Drawing.Point(21, 187);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "Septiembre";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton6.Location = new System.Drawing.Point(21, 164);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(58, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Agosto";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton7.Location = new System.Drawing.Point(21, 141);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.Text = "Julio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton8.Location = new System.Drawing.Point(21, 118);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(50, 17);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.Text = "Junio";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(21, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Abril";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton4.Location = new System.Drawing.Point(21, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "Marzo";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(21, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Febrero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Enero
            // 
            this.Enero.AutoSize = true;
            this.Enero.Checked = true;
            this.Enero.ForeColor = System.Drawing.Color.Transparent;
            this.Enero.Location = new System.Drawing.Point(21, 26);
            this.Enero.Name = "Enero";
            this.Enero.Size = new System.Drawing.Size(53, 17);
            this.Enero.TabIndex = 0;
            this.Enero.TabStop = true;
            this.Enero.Text = "Enero";
            this.Enero.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Con Descuento:";
            // 
            // labDescuentoTotal
            // 
            this.labDescuentoTotal.AutoSize = true;
            this.labDescuentoTotal.ForeColor = System.Drawing.Color.Green;
            this.labDescuentoTotal.Location = new System.Drawing.Point(64, 222);
            this.labDescuentoTotal.Name = "labDescuentoTotal";
            this.labDescuentoTotal.Size = new System.Drawing.Size(13, 13);
            this.labDescuentoTotal.TabIndex = 6;
            this.labDescuentoTotal.Text = "$";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.ForeColor = System.Drawing.Color.Green;
            this.labTotal.Location = new System.Drawing.Point(64, 159);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(13, 13);
            this.labTotal.TabIndex = 7;
            this.labTotal.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 360);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labDescuentoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "15% de descuento en el Mes De Octubre ¡No te lo pierdas!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radbtnOctubreOFF;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Enero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDescuentoTotal;
        private System.Windows.Forms.Label labTotal;
    }
}

