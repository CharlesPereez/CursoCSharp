using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();

            Console.WriteLine("Introduce la cantidad de elemetos (0 para cerrar)");

            int elem = 1;

            while (elem != 0)
            {
                elem = int.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Listado de elementos introducidos");

            foreach(int elemento in numeros)
            {
                
                Console.WriteLine(elemento);
               
            }


        }
    }
}
