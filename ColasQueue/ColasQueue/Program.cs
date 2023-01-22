using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numeros = new Stack<int>();

            //rellenando o agregando elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            //recorriendo la pila (stack)

            Console.WriteLine("Recorriendo el Queue");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminando elemento de la pila(Stack)
            Console.WriteLine("Eliminando elementos");
            numeros.Pop();

            Console.WriteLine("Recorriendo la pila (Stack)");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
