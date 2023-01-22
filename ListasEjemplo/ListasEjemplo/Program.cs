using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>(); // Declarar una lista

            Console.WriteLine("Introduce elementos en la coleccion (0 para cerrar)");

            int elem = 1;

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos");

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }



            // LISTA

            /*Console.WriteLine("cuantos elementos quieres introducir");

            int elem = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Elementos introducidos");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/




            //lista numeros ingresados por teclado

            /*Console.WriteLine("Ingrese la cantidad de elementos");

            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Elementos introducidos");

            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            //LISTA DE ELEMENTOS DE UN ARRAY

            /*int[] listaNumeros = new int[] { 10, 2, 15, 14, 50 };

            for (int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/



        }
    }
}
