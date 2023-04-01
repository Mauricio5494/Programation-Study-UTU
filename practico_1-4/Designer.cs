namespace Practico_1_4
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txbUnicoNumero = new System.Windows.Forms.TextBox();
            this.labNumero = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.labTXT = new System.Windows.Forms.Label();
            this.btnConsigna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(104, 151);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txbUnicoNumero
            // 
            this.txbUnicoNumero.BackColor = System.Drawing.SystemColors.WindowText;
            this.txbUnicoNumero.ForeColor = System.Drawing.Color.White;
            this.txbUnicoNumero.Location = new System.Drawing.Point(104, 125);
            this.txbUnicoNumero.Name = "txbUnicoNumero";
            this.txbUnicoNumero.Size = new System.Drawing.Size(100, 20);
            this.txbUnicoNumero.TabIndex = 1;
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(101, 109);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(44, 13);
            this.labNumero.TabIndex = 2;
            this.labNumero.Text = "Número";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(299, 128);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(16, 13);
            this.labRes.TabIndex = 3;
            this.labRes.Text = "...";
            // 
            // labTXT
            // 
            this.labTXT.AutoSize = true;
            this.labTXT.Location = new System.Drawing.Point(235, 128);
            this.labTXT.Name = "labTXT";
            this.labTXT.Size = new System.Drawing.Size(58, 13);
            this.labTXT.TabIndex = 4;
            this.labTXT.Text = "Resultado:";
            // 
            // btnConsigna
            // 
            this.btnConsigna.BackColor = System.Drawing.Color.Black;
            this.btnConsigna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsigna.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsigna.Location = new System.Drawing.Point(185, 151);
            this.btnConsigna.Name = "btnConsigna";
            this.btnConsigna.Size = new System.Drawing.Size(19, 23);
            this.btnConsigna.TabIndex = 5;
            this.btnConsigna.Text = "?";
            this.btnConsigna.UseVisualStyleBackColor = false;
            this.btnConsigna.Click += new System.EventHandler(this.btnConsigna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Productos \'El Gori\'";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsigna);
            this.Controls.Add(this.labTXT);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.labNumero);
            this.Controls.Add(this.txbUnicoNumero);
            this.Controls.Add(this.btnIngresar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Par o Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txbUnicoNumero;
        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Label labTXT;
        private System.Windows.Forms.Button btnConsigna;
        private System.Windows.Forms.Label label1;
    }
}

