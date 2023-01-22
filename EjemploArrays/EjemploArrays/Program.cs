using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int[4];

            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

        static void ProcesaDatos(int [] datos)
        {
            for(int i=0; i < 4; i++)
            {
                datos[i] += 10;
            }
        }

    }
}
