using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatoreo = numero.Next(0, 100);

            int minumero;

            int intento = 0;

            Console.WriteLine("Adivine el numero generado por el sistema");

            do
            {
                intento++;
                try
                {
                    minumero = Int32.Parse(Console.ReadLine());

                }
                catch (FormatException ex)
                {

                    Console.WriteLine("No has introducido el valor correcto");
                    minumero = 0;
                }
                if (minumero < aleatoreo) Console.WriteLine("EL numero es mas alto");
                if (minumero > aleatoreo) Console.WriteLine("EL numero es mas bajo");

            }while(minumero != aleatoreo);
        }
    }
}
