using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosPorValorPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(2, 6));

        }

        /*Esto es una sobrecarga de metodos, hay que tomar en cuenta que los metodos no tienen que tener el mismo tipo de dato en los argumentos,
         se puede poner otro tipo de dato pero hay que fijarse en el tipo de dato que tiene que devolver. */
        static int Suma(int numero1, int numero2) => numero1 + numero2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3) => numero1 + numero2;
    }
}
