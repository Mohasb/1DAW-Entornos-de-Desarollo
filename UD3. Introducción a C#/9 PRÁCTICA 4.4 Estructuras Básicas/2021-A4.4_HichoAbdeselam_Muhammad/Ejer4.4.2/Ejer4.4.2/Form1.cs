using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 15;

            num = num + 10;                     // num = 25 (15 + 10)
            num = 12 - (42 / 7);                // num = 6  (12 - 6)
            num++;                              // num = 7  (6 + 1)
            num *= 3;                           // num = 21 (3 * 7)

                                                // Pregunta 1: num = 21.


            int cont = 0;                       // cont = 0
            cont++;                             // cont = 1
            cont--;                             // cont = 0

                                                // Pregunta 2: cont = 0.


            string result = " Hola ";

            result += " otra vez" + result;

            MessageBox.Show(result);              //Aqui Strin result es: Hola otra vez Hola

            result = "The value is:" + cont;     //Pregunta 3: result = the value is 0


            bool yesNo = false;

            bool anotherBool = true;

            yesNo = !anotherBool;               //Pregunta 4:  false (por el simbolo exclamacion lo contrario de anotherbool que es false )

        }
    }
}
