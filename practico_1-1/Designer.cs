namespace práctico_1_1
{
    partial class Ventana1
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
            this.primerNumeroTextBox = new System.Windows.Forms.TextBox();
            this.segundoNumeroTextBox = new System.Windows.Forms.TextBox();
            this.tercerNumeroTextBox = new System.Windows.Forms.TextBox();
            this.cuartonumeroTextBox = new System.Windows.Forms.TextBox();
            this.calcularPromedioButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultimoPromedioLabel = new System.Windows.Forms.Label();
            this.numerosIngresadosLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resetButon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // primerNumeroTextBox
            // 
            this.primerNumeroTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.primerNumeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primerNumeroTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.primerNumeroTextBox.Location = new System.Drawing.Point(52, 46);
            this.primerNumeroTextBox.Name = "primerNumeroTextBox";
            this.primerNumeroTextBox.Size = new System.Drawing.Size(75, 20);
            this.primerNumeroTextBox.TabIndex = 0;
            this.primerNumeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primerNumeroTextBox.UseWaitCursor = true;
            this.primerNumeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNumeroTextBox_KeyPress);
            this.primerNumeroTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.primerNumeroTextBox_Validating);
            // 
            // segundoNumeroTextBox
            // 
            this.segundoNumeroTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.segundoNumeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.segundoNumeroTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.segundoNumeroTextBox.Location = new System.Drawing.Point(52, 85);
            this.segundoNumeroTextBox.Name = "segundoNumeroTextBox";
            this.segundoNumeroTextBox.Size = new System.Drawing.Size(75, 20);
            this.segundoNumeroTextBox.TabIndex = 1;
            this.segundoNumeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.segundoNumeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.segundoNumeroTextBox_KeyPress);
            this.segundoNumeroTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.segundoNumeroTextBox_Validating);
            // 
            // tercerNumeroTextBox
            // 
            this.tercerNumeroTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tercerNumeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tercerNumeroTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.tercerNumeroTextBox.Location = new System.Drawing.Point(52, 127);
            this.tercerNumeroTextBox.Name = "tercerNumeroTextBox";
            this.tercerNumeroTextBox.Size = new System.Drawing.Size(75, 20);
            this.tercerNumeroTextBox.TabIndex = 2;
            this.tercerNumeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tercerNumeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tercerNumeroTextBox_KeyPress);
            this.tercerNumeroTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tercerNumeroTextBox_Validating);
            // 
            // cuartonumeroTextBox
            // 
            this.cuartonumeroTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cuartonumeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuartonumeroTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.cuartonumeroTextBox.Location = new System.Drawing.Point(52, 168);
            this.cuartonumeroTextBox.Name = "cuartonumeroTextBox";
            this.cuartonumeroTextBox.Size = new System.Drawing.Size(75, 20);
            this.cuartonumeroTextBox.TabIndex = 3;
            this.cuartonumeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cuartonumeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuartonumeroTextBox_KeyPress);
            this.cuartonumeroTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuartonumeroTextBox_Validating);
            // 
            // calcularPromedioButton
            // 
            this.calcularPromedioButton.BackColor = System.Drawing.Color.Gray;
            this.calcularPromedioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcularPromedioButton.ForeColor = System.Drawing.SystemColors.Window;
            this.calcularPromedioButton.Location = new System.Drawing.Point(52, 207);
            this.calcularPromedioButton.Name = "calcularPromedioButton";
            this.calcularPromedioButton.Size = new System.Drawing.Size(75, 23);
            this.calcularPromedioButton.TabIndex = 4;
            this.calcularPromedioButton.Tag = "";
            this.calcularPromedioButton.Text = "Calcular";
            this.calcularPromedioButton.UseVisualStyleBackColor = false;
            this.calcularPromedioButton.Click += new System.EventHandler(this.calcularPromedioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio:";
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Location = new System.Drawing.Point(224, 85);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(16, 13);
            this.promedioLabel.TabIndex = 7;
            this.promedioLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Último promedio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.ultimoPromedioLabel);
            this.groupBox1.Controls.Add(this.numerosIngresadosLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(167, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial";
            // 
            // ultimoPromedioLabel
            // 
            this.ultimoPromedioLabel.AutoSize = true;
            this.ultimoPromedioLabel.Location = new System.Drawing.Point(97, 49);
            this.ultimoPromedioLabel.Name = "ultimoPromedioLabel";
            this.ultimoPromedioLabel.Size = new System.Drawing.Size(16, 13);
            this.ultimoPromedioLabel.TabIndex = 11;
            this.ultimoPromedioLabel.Text = "...";
            // 
            // numerosIngresadosLabel
            // 
            this.numerosIngresadosLabel.AutoSize = true;
            this.numerosIngresadosLabel.Location = new System.Drawing.Point(118, 23);
            this.numerosIngresadosLabel.Name = "numerosIngresadosLabel";
            this.numerosIngresadosLabel.Size = new System.Drawing.Size(16, 13);
            this.numerosIngresadosLabel.TabIndex = 10;
            this.numerosIngresadosLabel.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Números ingresados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mauricio Gori 3er BF";
            // 
            // resetButon
            // 
            this.resetButon.BackColor = System.Drawing.Color.Gray;
            this.resetButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButon.ForeColor = System.Drawing.SystemColors.Window;
            this.resetButon.Location = new System.Drawing.Point(52, 236);
            this.resetButon.Name = "resetButon";
            this.resetButon.Size = new System.Drawing.Size(75, 23);
            this.resetButon.TabIndex = 11;
            this.resetButon.Text = "reset";
            this.resetButon.UseVisualStyleBackColor = false;
            this.resetButon.Click += new System.EventHandler(this.resetButon_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(476, 277);
            this.Controls.Add(this.resetButon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularPromedioButton);
            this.Controls.Add(this.cuartonumeroTextBox);
            this.Controls.Add(this.tercerNumeroTextBox);
            this.Controls.Add(this.segundoNumeroTextBox);
            this.Controls.Add(this.primerNumeroTextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Ventana1";
            this.Text = "Promedio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primerNumeroTextBox;
        private System.Windows.Forms.TextBox segundoNumeroTextBox;
        private System.Windows.Forms.TextBox tercerNumeroTextBox;
        private System.Windows.Forms.TextBox cuartonumeroTextBox;
        private System.Windows.Forms.Button calcularPromedioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ultimoPromedioLabel;
        private System.Windows.Forms.Label numerosIngresadosLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resetButon;
    }
}

