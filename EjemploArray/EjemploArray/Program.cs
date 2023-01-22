using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiento desde el Main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }

        static int [] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el Array");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int [] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el datos para la posicion {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }
            return datos;
        }
    }
}
