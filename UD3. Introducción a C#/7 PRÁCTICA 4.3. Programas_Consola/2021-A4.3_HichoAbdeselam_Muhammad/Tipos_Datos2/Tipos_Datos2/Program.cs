using System;

namespace Tipos_Datos2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;

            Console.WriteLine("DIGITE UN NUMERO:");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("DIGITE OTRO NUMERO:");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("EL VALOR ABSOLUTO: " + Math.Abs(num1));
            Console.WriteLine("POTENCIA: " + Math.Pow(num1, 3));       
            Console.WriteLine("RAIZ CUADRADA: " + Math.Sqrt(num1));
            Console.WriteLine("SENO: " + Math.Sin(num1));
            Console.WriteLine("COSENO: " + Math.Cos(num1));
            Console.WriteLine("NUMERO MÁXIMO: " + Math.Max(num1, num2));
            Console.WriteLine("NUMERO MÍNIMO: " + Math.Min(num1, num2));
            Console.WriteLine("PARTE ENTERA: " + Math.Truncate(Math.Sqrt(num1)));    
            Console.WriteLine("REDONDEO: " + Math.Round(Math.Sqrt(num1)));
            Console.ReadLine();




        }
    }
}
