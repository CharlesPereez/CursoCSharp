using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sumaNumeros(17, 2);
            //Console.WriteLine($"La suma es {sumaNumeros(3, 5)}");

            Console.WriteLine(divideNumeros(18, 7));
            Console.WriteLine(divideNumero(6,3));
        }

        //tenemos que tener en cuenta el tipo de dato que devuelve nuestro metodo,
        // asi como saber que un int sumado por otro int dará un entero.

        static double divideNumeros(double num1, int num2)
        {
            return num1 / num2;
        }

        static double divideNumero(double num1, int num2) => num1 / num2;


        //static int sumaNumeros(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static void sumaNumeros(int num1, int num2)
        //{
        //    Console.WriteLine($"La suma es: {num1 + num2}");
        //}

     
    }
}
