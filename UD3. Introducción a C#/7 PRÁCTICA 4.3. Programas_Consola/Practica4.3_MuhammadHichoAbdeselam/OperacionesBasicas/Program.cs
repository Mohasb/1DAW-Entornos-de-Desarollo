using System;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0f;
            float numero2 = 0f;

            Console.Write("PRIMER NÚMERO: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NÚMERO: ");
            numero2 = float.Parse(Console.ReadLine());

            float suma = numero1 + numero2;
            float resta = numero1 - numero2;
            float multiplicacion = numero1 * numero2;
            float division = numero1 / numero2;
            float resto = numero1 % numero2;

            Console.WriteLine("LA SUMA " + numero1 + " + " + numero2 + " ES IGUAL A: " + suma);
            Console.WriteLine("LA RESTA " + numero1 + " - " + numero2 + " ES IGUAL A: " + resta);
            Console.WriteLine("LA MULTIPLICACIÓN " + numero1 + " * " + numero2 + " ES IGUAL A: " +   multiplicacion);
            Console.WriteLine("LA DIVISIÓN " + numero1 + " / " + numero2 + " ES IGUAL A: " + division);
            Console.WriteLine("EL RESTO " + numero1 + " % " + numero2 + " ES IGUAL A: " + resto);
        }
    }
}
