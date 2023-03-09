using System;

namespace ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0f;
            float numero2 = 0f;

            Console.Write("DIGITE UN NÚMERO: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("DIGITE OTRO NÚMERO: ");
            numero2 = float.Parse(Console.ReadLine());



            Console.WriteLine("EL VALOR ABSOLUTO: " + Math.Abs(numero1));
            Console.WriteLine("POTENCIA: " + Math.Pow(numero1, 3));
            Console.WriteLine("RAIZ CUADRADA: " + Math.Sqrt(numero1));
            Console.WriteLine("SENO: " + Math.Sin(numero1));
            Console.WriteLine("COSENO: " + Math.Cos(numero1));
            Console.WriteLine("NUMERO MÁXIMO: " + Math.Max(numero1, numero2));
            Console.WriteLine("NUMERO MÍNIMO: " + Math.Min(numero1, numero2));
            Console.WriteLine("PARTE ENTERA: " + Math.Truncate(Math.Sqrt(numero1)));
            Console.WriteLine("REDONDEO: " + Math.Round(Math.Sqrt(numero1)));
            Console.ReadLine();

        }
    }
}
