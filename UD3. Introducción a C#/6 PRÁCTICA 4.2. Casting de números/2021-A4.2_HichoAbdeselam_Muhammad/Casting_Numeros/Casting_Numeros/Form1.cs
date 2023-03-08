using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertir_Entero_Click(object sender, EventArgs e)
        {
            int numero = 0;  
            int doble = 0;
            int mitad = 0;

            numero = int.Parse(textBox1.Text);    //Paso de texto a int
            doble = numero * 2;   //Lo que vale el doble
            mitad = numero / 2;   //Lo que vale la mitad

            textBox3.Text = doble.ToString();   //En el "textBox 3" escribe el resultado(doble) + pasar a String para mostrarlo
            textBox4.Text = mitad.ToString();   //En el "textBox 4" escribe el resultado(mitad) + pasar a String para mostrarlo 

            // No entiendo por que le he puesto "&" para subrallar y dar acceso a funcion cuando compilas no sale pero en el programa si
        }

        private void convertir_Real_Click(object sender, EventArgs e)
        {
            float numeroReal = 0;
            float dobleReal = 0;
            float mitadReal = 0;

            numeroReal = float.Parse(textBox2.Text);   //Igual que arriba pero con float...
            dobleReal = numeroReal * 2;
            mitadReal = numeroReal / 2;

            textBox3.Text = dobleReal.ToString();
            textBox4.Text = mitadReal.ToString();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // salir de la aplicacion
        }
    }
}
