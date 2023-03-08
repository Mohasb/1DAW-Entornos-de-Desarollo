using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastingNumeros
{
    public partial class Form_CastingNumeros : Form
    {
        int entero = 0;
        float real = 0f;

        public Form_CastingNumeros()
        {
            InitializeComponent();
        }
        


        //Comportamiento botón convertir entero
        private void btn_Entero_Click(object sender, EventArgs e)
        {
            //Control de introducion de valor vacio
            if (tBox_Entero.Text == null || tBox_Entero.Text == "")
            {
                MessageBox.Show("Primero introduce un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                entero = int.Parse(tBox_Entero.Text);    
                tBox_Doble.Text = (entero * 2).ToString();  //Impresión en el textBox el valor de entero por 2 y pasado a String
                tBox_Mitad.Text = (entero / 2).ToString();
            }
        }
        //Comportamiento botón convertir real
        private void btn_Real_Click(object sender, EventArgs e)
        {
            if (tBox_Real.Text == null || tBox_Real.Text == "")
            {
                MessageBox.Show("Primero introduce un número real", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Control para reemplazar el '.' por la ',' para que el programa calcule bien
                real = float.Parse(tBox_Real.Text.Replace(".", ","));
                tBox_Doble.Text = (real * 2).ToString();
                tBox_Mitad.Text = (real / 2).ToString();
            }
        }
        //Comportamiento botón convertir salir
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
