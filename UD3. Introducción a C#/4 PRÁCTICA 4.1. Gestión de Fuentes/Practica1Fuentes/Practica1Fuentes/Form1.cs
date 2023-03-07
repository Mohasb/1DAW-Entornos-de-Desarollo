using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Negrita_Click(object sender, EventArgs e)
        {
            if (!lbl_Texto.Font.Bold)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Bold);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void btn_Cursiva_Click(object sender, EventArgs e)
        {
            if (!lbl_Texto.Font.Italic)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Italic);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Italic);
            }
        }

        private void btn_Subrayada_Click(object sender, EventArgs e)
        {
            if (!lbl_Texto.Font.Underline)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Underline);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Underline);
            }
        }
    }
}
