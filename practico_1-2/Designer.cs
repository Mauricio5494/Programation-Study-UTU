
namespace Practico_1_2
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
            this.txtNinas = new System.Windows.Forms.TextBox();
            this.txtNinos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labTotalIngresados = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labNinasPorcentaje = new System.Windows.Forms.Label();
            this.labNinosPorcentaje = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTotalHistorial = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labNinasHistorial = new System.Windows.Forms.Label();
            this.labNinosHistorial = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnResetHistorial = new System.Windows.Forms.Button();
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular = new System.Windows.Forms.Label();
            this.btnEasterEgg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(134, 144);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNinas
            // 
            this.txtNinas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNinas.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNinas.Location = new System.Drawing.Point(123, 118);
            this.txtNinas.Name = "txtNinas";
            this.txtNinas.Size = new System.Drawing.Size(100, 20);
            this.txtNinas.TabIndex = 1;
            this.txtNinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNinas_KeyPress);
            // 
            // txtNinos
            // 
            this.txtNinos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNinos.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNinos.Location = new System.Drawing.Point(123, 92);
            this.txtNinos.Name = "txtNinos";
            this.txtNinos.Size = new System.Drawing.Size(100, 20);
            this.txtNinos.TabIndex = 2;
            this.txtNinos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNinos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cálculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niños:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Niñas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEasterEgg);
            this.groupBox1.Controls.Add(this.labTotalIngresados);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labNinasPorcentaje);
            this.groupBox1.Controls.Add(this.labNinosPorcentaje);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(252, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porcentajes";
            // 
            // labTotalIngresados
            // 
            this.labTotalIngresados.AutoSize = true;
            this.labTotalIngresados.Location = new System.Drawing.Point(45, 73);
            this.labTotalIngresados.Name = "labTotalIngresados";
            this.labTotalIngresados.Size = new System.Drawing.Size(16, 13);
            this.labTotalIngresados.TabIndex = 9;
            this.labTotalIngresados.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total:";
            // 
            // labNinasPorcentaje
            // 
            this.labNinasPorcentaje.AutoSize = true;
            this.labNinasPorcentaje.Location = new System.Drawing.Point(48, 50);
            this.labNinasPorcentaje.Name = "labNinasPorcentaje";
            this.labNinasPorcentaje.Size = new System.Drawing.Size(16, 13);
            this.labNinasPorcentaje.TabIndex = 7;
            this.labNinasPorcentaje.Text = "...";
            // 
            // labNinosPorcentaje
            // 
            this.labNinosPorcentaje.AutoSize = true;
            this.labNinosPorcentaje.Location = new System.Drawing.Point(48, 27);
            this.labNinosPorcentaje.Name = "labNinosPorcentaje";
            this.labNinosPorcentaje.Size = new System.Drawing.Size(16, 13);
            this.labNinosPorcentaje.TabIndex = 6;
            this.labNinosPorcentaje.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Niños";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Niñas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTotalHistorial);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labNinasHistorial);
            this.groupBox2.Controls.Add(this.labNinosHistorial);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(252, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial";
            // 
            // labTotalHistorial
            // 
            this.labTotalHistorial.AutoSize = true;
            this.labTotalHistorial.Location = new System.Drawing.Point(45, 73);
            this.labTotalHistorial.Name = "labTotalHistorial";
            this.labTotalHistorial.Size = new System.Drawing.Size(16, 13);
            this.labTotalHistorial.TabIndex = 9;
            this.labTotalHistorial.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total:";
            // 
            // labNinasHistorial
            // 
            this.labNinasHistorial.AutoSize = true;
            this.labNinasHistorial.Location = new System.Drawing.Point(48, 50);
            this.labNinasHistorial.Name = "labNinasHistorial";
            this.labNinasHistorial.Size = new System.Drawing.Size(16, 13);
            this.labNinasHistorial.TabIndex = 7;
            this.labNinasHistorial.Text = "...";
            // 
            // labNinosHistorial
            // 
            this.labNinosHistorial.AutoSize = true;
            this.labNinosHistorial.Location = new System.Drawing.Point(48, 27);
            this.labNinosHistorial.Name = "labNinosHistorial";
            this.labNinosHistorial.Size = new System.Drawing.Size(16, 13);
            this.labNinosHistorial.TabIndex = 6;
            this.labNinosHistorial.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Niños:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Niñas:";
            // 
            // btnResetear
            // 
            this.btnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetear.Location = new System.Drawing.Point(134, 173);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 12;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnResetHistorial
            // 
            this.btnResetHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetHistorial.Location = new System.Drawing.Point(300, 288);
            this.btnResetHistorial.Name = "btnResetHistorial";
            this.btnResetHistorial.Size = new System.Drawing.Size(106, 23);
            this.btnResetHistorial.TabIndex = 13;
            this.btnResetHistorial.Text = "Resetar Historial";
            this.btnResetHistorial.UseVisualStyleBackColor = true;
            this.btnResetHistorial.Click += new System.EventHandler(this.btnResetHistorial_Click);
            // 
            // labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular
            // 
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.AutoSize = true;
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Location = new System.Drawing.Point(188, 342);
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Name = "labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConS" +
    "oloApretarElBotonDeCalcular";
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Size = new System.Drawing.Size(116, 19);
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.TabIndex = 14;
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Text = "Productos \"El Gori\"";
            this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular.Click += new System.EventHandler(this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular_Click);
            // 
            // btnEasterEgg
            // 
            this.btnEasterEgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasterEgg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEasterEgg.Location = new System.Drawing.Point(160, 19);
            this.btnEasterEgg.Name = "btnEasterEgg";
            this.btnEasterEgg.Size = new System.Drawing.Size(10, 10);
            this.btnEasterEgg.TabIndex = 15;
            this.btnEasterEgg.Text = "button1";
            this.btnEasterEgg.UseVisualStyleBackColor = true;
            this.btnEasterEgg.Click += new System.EventHandler(this.btnEasterEgg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular);
            this.Controls.Add(this.btnResetHistorial);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNinos);
            this.Controls.Add(this.txtNinas);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Calculadora en %";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNinas;
        private System.Windows.Forms.TextBox txtNinos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labTotalIngresados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labNinasPorcentaje;
        private System.Windows.Forms.Label labNinosPorcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labTotalHistorial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labNinasHistorial;
        private System.Windows.Forms.Label labNinosHistorial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnResetHistorial;
        private System.Windows.Forms.Label labElCreadorTodoPoderosoDeEsteProgramaCapazDeDestruirSistemasEstelaresEnterosConSoloApretarElBotonDeCalcular;
        private System.Windows.Forms.Button btnEasterEgg;
    }
}
