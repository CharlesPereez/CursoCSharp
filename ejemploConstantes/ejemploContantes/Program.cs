using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploContantes
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
