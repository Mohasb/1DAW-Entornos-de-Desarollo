
namespace CastingNumeros
{
    partial class Form_CastingNumeros
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
            this.lbl_Entero = new System.Windows.Forms.Label();
            this.lbl_Real = new System.Windows.Forms.Label();
            this.tBox_Entero = new System.Windows.Forms.TextBox();
            this.tBox_Real = new System.Windows.Forms.TextBox();
            this.lbl_Doble = new System.Windows.Forms.Label();
            this.lbl_Mitad = new System.Windows.Forms.Label();
            this.tBox_Doble = new System.Windows.Forms.TextBox();
            this.tBox_Mitad = new System.Windows.Forms.TextBox();
            this.btn_Entero = new System.Windows.Forms.Button();
            this.btn_Real = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Entero
            // 
            this.lbl_Entero.AutoSize = true;
            this.lbl_Entero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Entero.Location = new System.Drawing.Point(26, 41);
            this.lbl_Entero.Name = "lbl_Entero";
            this.lbl_Entero.Size = new System.Drawing.Size(224, 28);
            this.lbl_Entero.TabIndex = 0;
            this.lbl_Entero.Text = "Dime un número entero:";
            // 
            // lbl_Real
            // 
            this.lbl_Real.AutoSize = true;
            this.lbl_Real.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Real.Location = new System.Drawing.Point(26, 99);
            this.lbl_Real.Name = "lbl_Real";
            this.lbl_Real.Size = new System.Drawing.Size(199, 28);
            this.lbl_Real.TabIndex = 1;
            this.lbl_Real.Text = "Dime un número real:";
            // 
            // tBox_Entero
            // 
            this.tBox_Entero.Location = new System.Drawing.Point(280, 42);
            this.tBox_Entero.Name = "tBox_Entero";
            this.tBox_Entero.Size = new System.Drawing.Size(125, 27);
            this.tBox_Entero.TabIndex = 2;
            // 
            // tBox_Real
            // 
            this.tBox_Real.Location = new System.Drawing.Point(280, 101);
            this.tBox_Real.Name = "tBox_Real";
            this.tBox_Real.Size = new System.Drawing.Size(125, 27);
            this.tBox_Real.TabIndex = 3;
            // 
            // lbl_Doble
            // 
            this.lbl_Doble.AutoSize = true;
            this.lbl_Doble.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Doble.Location = new System.Drawing.Point(35, 172);
            this.lbl_Doble.Name = "lbl_Doble";
            this.lbl_Doble.Size = new System.Drawing.Size(215, 28);
            this.lbl_Doble.TabIndex = 4;
            this.lbl_Doble.Text = "El doble del número es:";
            // 
            // lbl_Mitad
            // 
            this.lbl_Mitad.AutoSize = true;
            this.lbl_Mitad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mitad.Location = new System.Drawing.Point(35, 216);
            this.lbl_Mitad.Name = "lbl_Mitad";
            this.lbl_Mitad.Size = new System.Drawing.Size(219, 28);
            this.lbl_Mitad.TabIndex = 5;
            this.lbl_Mitad.Text = "La mitad del número es:";
            // 
            // tBox_Doble
            // 
            this.tBox_Doble.Location = new System.Drawing.Point(280, 173);
            this.tBox_Doble.Name = "tBox_Doble";
            this.tBox_Doble.Size = new System.Drawing.Size(125, 27);
            this.tBox_Doble.TabIndex = 6;
            // 
            // tBox_Mitad
            // 
            this.tBox_Mitad.Location = new System.Drawing.Point(280, 217);
            this.tBox_Mitad.Name = "tBox_Mitad";
            this.tBox_Mitad.Size = new System.Drawing.Size(125, 27);
            this.tBox_Mitad.TabIndex = 7;
            // 
            // btn_Entero
            // 
            this.btn_Entero.Location = new System.Drawing.Point(442, 39);
            this.btn_Entero.Name = "btn_Entero";
            this.btn_Entero.Size = new System.Drawing.Size(94, 29);
            this.btn_Entero.TabIndex = 8;
            this.btn_Entero.Text = "&Convertir";
            this.btn_Entero.UseVisualStyleBackColor = true;
            this.btn_Entero.Click += new System.EventHandler(this.btn_Entero_Click);
            // 
            // btn_Real
            // 
            this.btn_Real.Location = new System.Drawing.Point(442, 98);
            this.btn_Real.Name = "btn_Real";
            this.btn_Real.Size = new System.Drawing.Size(94, 29);
            this.btn_Real.TabIndex = 9;
            this.btn_Real.Text = "&Convertir";
            this.btn_Real.UseVisualStyleBackColor = true;
            this.btn_Real.Click += new System.EventHandler(this.btn_Real_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(442, 229);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(94, 29);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form_CastingNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 304);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Real);
            this.Controls.Add(this.btn_Entero);
            this.Controls.Add(this.tBox_Mitad);
            this.Controls.Add(this.tBox_Doble);
            this.Controls.Add(this.lbl_Mitad);
            this.Controls.Add(this.lbl_Doble);
            this.Controls.Add(this.tBox_Real);
            this.Controls.Add(this.tBox_Entero);
            this.Controls.Add(this.lbl_Real);
            this.Controls.Add(this.lbl_Entero);
            this.MaximizeBox = false;
            this.Name = "Form_CastingNumeros";
            this.Text = "TRABAJANDO CON CADENAS Y NUMEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Entero;
        private System.Windows.Forms.Label lbl_Real;
        private System.Windows.Forms.TextBox tBox_Entero;
        private System.Windows.Forms.TextBox tBox_Real;
        private System.Windows.Forms.Label lbl_Doble;
        private System.Windows.Forms.Label lbl_Mitad;
        private System.Windows.Forms.TextBox tBox_Doble;
        private System.Windows.Forms.TextBox tBox_Mitad;
        private System.Windows.Forms.Button btn_Entero;
        private System.Windows.Forms.Button btn_Real;
        private System.Windows.Forms.Button btn_Salir;
    }
}

