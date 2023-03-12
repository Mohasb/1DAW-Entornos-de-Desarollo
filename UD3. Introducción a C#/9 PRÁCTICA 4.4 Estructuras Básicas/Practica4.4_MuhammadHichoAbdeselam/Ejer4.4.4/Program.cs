using System;

namespace Ejer4._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float nota1 = 0f;
            float nota2 = 0f;
            int numeroAlumnos = 0;
            float promedio = 0;
            float suma = 0;


            Console.Write("¿Cuantos alumnos desea calificar?:");
            numeroAlumnos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroAlumnos; i++)
            {
                Console.Write("NOMBRE:");
                nombre = Console.ReadLine();

                Console.Write("NOTA 1:");
                nota1 = float.Parse(Console.ReadLine());

                Console.Write("NOTA 2:");
                nota2 = float.Parse(Console.ReadLine());

                promedio = ((nota1 + nota2) / 2);
                Console.WriteLine("PROMEDIO: " + promedio);

                suma += promedio;
            }

            Console.WriteLine("SUMA TOTAL ES: " + suma);
            Console.WriteLine("MEDIA ARITMETICA: " + suma / numeroAlumnos);
        }
    }
}
