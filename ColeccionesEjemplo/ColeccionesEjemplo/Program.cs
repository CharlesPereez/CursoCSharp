using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] { 10, 20, 30, 40, 50 })
            {
                numeros.AddLast(numero);
            }

            //numeros.Remove(10);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(90);

            numeros.AddFirst(nodoImportante);

            /*foreach (int numero in numeros)
            {
                Console.WriteLine(numero);               
            }*/

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;

                Console.WriteLine(numero);
            }
            
        }
    }
}
