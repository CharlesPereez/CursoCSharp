using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Escriba el radio a calcular");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El area es: {area}");

        }

    }
}