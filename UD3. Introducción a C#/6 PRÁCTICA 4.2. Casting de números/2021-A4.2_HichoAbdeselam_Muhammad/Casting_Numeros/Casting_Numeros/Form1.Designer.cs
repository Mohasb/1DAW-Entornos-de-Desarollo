
namespace Casting_Numeros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Entero = new System.Windows.Forms.Label();
            this.text_Real = new System.Windows.Forms.Label();
            this.text_Doble = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.convertir_Entero = new System.Windows.Forms.Button();
            this.convertir_Real = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Entero
            // 
            this.text_Entero.AutoSize = true;
            this.text_Entero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_Entero.Location = new System.Drawing.Point(43, 57);
            this.text_Entero.Name = "text_Entero";
            this.text_Entero.Size = new System.Drawing.Size(287, 35);
            this.text_Entero.TabIndex = 0;
            this.text_Entero.Text = "Dime un numero entero:";
            // 
            // text_Real
            // 
            this.text_Real.AutoSize = true;
            this.text_Real.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_Real.Location = new System.Drawing.Point(43, 139);
            this.text_Real.Name = "text_Real";
            this.text_Real.Size = new System.Drawing.Size(256, 35);
            this.text_Real.TabIndex = 1;
            this.text_Real.Text = "Dime un numero real:";
            // 
            // text_Doble
            // 
            this.text_Doble.AutoSize = true;
            this.text_Doble.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_Doble.Location = new System.Drawing.Point(77, 288);
            this.text_Doble.Name = "text_Doble";
            this.text_Doble.Size = new System.Drawing.Size(276, 35);
            this.text_Doble.TabIndex = 2;
            this.text_Doble.Text = "El doble del numero es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "La mitad del numero es:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(404, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(404, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 7;
            // 
            // convertir_Entero
            // 
            this.convertir_Entero.AutoSize = true;
            this.convertir_Entero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertir_Entero.Location = new System.Drawing.Point(645, 47);
            this.convertir_Entero.Name = "convertir_Entero";
            this.convertir_Entero.Size = new System.Drawing.Size(126, 45);
            this.convertir_Entero.TabIndex = 8;
            this.convertir_Entero.Text = "&Convertir";
            this.convertir_Entero.UseVisualStyleBackColor = true;
            this.convertir_Entero.Click += new System.EventHandler(this.convertir_Entero_Click);
            // 
            // convertir_Real
            // 
            this.convertir_Real.AutoSize = true;
            this.convertir_Real.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertir_Real.Location = new System.Drawing.Point(645, 129);
            this.convertir_Real.Name = "convertir_Real";
            this.convertir_Real.Size = new System.Drawing.Size(126, 45);
            this.convertir_Real.TabIndex = 9;
            this.convertir_Real.Text = "&Convertir";
            this.convertir_Real.UseVisualStyleBackColor = true;
            this.convertir_Real.Click += new System.EventHandler(this.convertir_Real_Click);
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salir.Location = new System.Drawing.Point(645, 360);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(126, 45);
            this.salir.TabIndex = 10;
            this.salir.Text = "&Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.convertir_Real);
            this.Controls.Add(this.convertir_Entero);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Doble);
            this.Controls.Add(this.text_Real);
            this.Controls.Add(this.text_Entero);
            this.Name = "Form1";
            this.Text = "TRABAJANDO CON CADENAS Y NUMEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_Entero;
        private System.Windows.Forms.Label text_Real;
        private System.Windows.Forms.Label text_Doble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button convertir_Entero;
        private System.Windows.Forms.Button convertir_Real;
        private System.Windows.Forms.Button salir;
    }
}

