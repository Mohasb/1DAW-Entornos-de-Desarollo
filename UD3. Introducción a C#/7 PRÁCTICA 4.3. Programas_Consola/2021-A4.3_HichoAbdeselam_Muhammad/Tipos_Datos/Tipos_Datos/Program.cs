using System;

namespace Tipos_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float suma = 0;
            float resta = 0;
            float multip = 0;
            float divis = 0;
            float residuo = 0;


            Console.WriteLine("PRIMER NUMERO: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO NUMERO: ");
            num2 = float.Parse(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            multip = num1 * num2;
            divis = num1 / num2;
            residuo = num1 % num2;



            Console.WriteLine("LA SUMA ES: " + num1 + " + " + num2 + " = " + suma );
            Console.WriteLine("LA RESTA ES: " + num1 + " - " + num2 + " = " + resta);
            Console.WriteLine("LA MULTIPLICACION ES: " + num1 + " * " + num2 + " = " + multip);
            Console.WriteLine("LA DIVISION ES: " + num1 + " / " + num2 + " = " + divis);
            Console.WriteLine("EL RESIDUO ES: " + num1 + " % " + num2 + " = " + residuo);
            Console.ReadLine();



        }
    }
}
