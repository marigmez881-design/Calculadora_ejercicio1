namespace Calculadora_ejercicio1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBB1 = new System.Windows.Forms.TextBox();
            this.TextBB2 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBB1
            // 
            this.TextBB1.Location = new System.Drawing.Point(113, 92);
            this.TextBB1.Name = "TextBB1";
            this.TextBB1.Size = new System.Drawing.Size(100, 22);
            this.TextBB1.TabIndex = 0;
            // 
            // TextBB2
            // 
            this.TextBB2.Location = new System.Drawing.Point(113, 205);
            this.TextBB2.Name = "TextBB2";
            this.TextBB2.Size = new System.Drawing.Size(100, 22);
            this.TextBB2.TabIndex = 1;
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(475, 33);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "S";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(475, 91);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(75, 23);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "M";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(475, 153);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(75, 23);
            this.Potencia.TabIndex = 4;
            this.Potencia.Text = "P";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.button3_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(475, 216);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 5;
            this.Division.Text = "D";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(475, 290);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(75, 23);
            this.Factorial.TabIndex = 6;
            this.Factorial.Text = "F";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.TextBB2);
            this.Controls.Add(this.TextBB1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBB1;
        private System.Windows.Forms.TextBox TextBB2;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Factorial;
    }
}