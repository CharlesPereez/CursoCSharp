using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosParametrosOpciones_cap13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 12;

            double num2 = 2.3;

            double num3 = 8.2;

            Console.WriteLine(suma(num1, num2, num3));
        }


        //Aqui la sobrecarga es correcta porque nos devuelve el mismo tipo de dato (double), tenemos el mismo nombre, y reciben diferente numero de parametros.
        static double suma(int num1, double num2, double num3 = 0) => num1 + num2 + num3;

        static double suma (int num1, double num2) => num1 + num2;

    }
}
