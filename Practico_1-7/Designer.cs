namespace Practico_1_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txbNumero
            // 
            this.txbNumero.BackColor = System.Drawing.SystemColors.WindowText;
            this.txbNumero.ForeColor = System.Drawing.Color.White;
            this.txbNumero.Location = new System.Drawing.Point(113, 108);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            this.txbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumero_KeyPress);
            this.txbNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txbNumero_Validating);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(113, 134);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(301, 111);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(16, 13);
            this.labRes.TabIndex = 3;
            this.labRes.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(113, 163);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(544, 327);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Meses y Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrar;
    }
}

