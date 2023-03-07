
namespace Practica1Fuentes
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
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.btn_Negrita = new System.Windows.Forms.Button();
            this.btn_Cursiva = new System.Windows.Forms.Button();
            this.btn_Subrayada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Texto.Location = new System.Drawing.Point(186, 108);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(185, 20);
            this.lbl_Texto.TabIndex = 0;
            this.lbl_Texto.Text = "En un lugar de la mancha...";
            // 
            // btn_Negrita
            // 
            this.btn_Negrita.Location = new System.Drawing.Point(186, 184);
            this.btn_Negrita.Name = "btn_Negrita";
            this.btn_Negrita.Size = new System.Drawing.Size(94, 29);
            this.btn_Negrita.TabIndex = 1;
            this.btn_Negrita.Text = "Negrita";
            this.btn_Negrita.UseVisualStyleBackColor = true;
            this.btn_Negrita.Click += new System.EventHandler(this.btn_Negrita_Click);
            // 
            // btn_Cursiva
            // 
            this.btn_Cursiva.Location = new System.Drawing.Point(300, 184);
            this.btn_Cursiva.Name = "btn_Cursiva";
            this.btn_Cursiva.Size = new System.Drawing.Size(94, 29);
            this.btn_Cursiva.TabIndex = 2;
            this.btn_Cursiva.Text = "Cursiva";
            this.btn_Cursiva.UseVisualStyleBackColor = true;
            this.btn_Cursiva.Click += new System.EventHandler(this.btn_Cursiva_Click);
            // 
            // btn_Subrayada
            // 
            this.btn_Subrayada.Location = new System.Drawing.Point(414, 184);
            this.btn_Subrayada.Name = "btn_Subrayada";
            this.btn_Subrayada.Size = new System.Drawing.Size(94, 29);
            this.btn_Subrayada.TabIndex = 3;
            this.btn_Subrayada.Text = "Subrayada";
            this.btn_Subrayada.UseVisualStyleBackColor = true;
            this.btn_Subrayada.Click += new System.EventHandler(this.btn_Subrayada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Subrayada);
            this.Controls.Add(this.btn_Cursiva);
            this.Controls.Add(this.btn_Negrita);
            this.Controls.Add(this.lbl_Texto);
            this.Name = "Form1";
            this.Text = "Práctica 4.1 Gestión De Fuentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Button btn_Negrita;
        private System.Windows.Forms.Button btn_Cursiva;
        private System.Windows.Forms.Button btn_Subrayada;
    }
}

