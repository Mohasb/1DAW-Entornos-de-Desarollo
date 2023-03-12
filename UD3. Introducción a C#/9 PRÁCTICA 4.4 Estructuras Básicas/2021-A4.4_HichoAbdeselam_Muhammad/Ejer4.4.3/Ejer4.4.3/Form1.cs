using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Quentin";
            int x = 3;

            x = x * 17;

            double d = Math.PI / 2;

            MessageBox.Show("name is " + name + "\nx is " + x + "\nd is" + d);


            // Es un salto de linea
            // Funncion Math que devuelve el valor del numero PI
            // "d" vale el valor de PI/2 (1.57079632679)


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < 10)
            {
                cont = cont + 1;
            }
            for (int i = 0; i <5; i++)
            {
                cont = cont - 1;
            }

            // cont vale 5

            MessageBox.Show("La respuesta es: " + cont);
        }
    }
}
