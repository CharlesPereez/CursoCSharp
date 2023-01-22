using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de números por teclado, obtener su promedio. 
            Finalizar la carga de valores cuando se cargue el valor 0.*/

            int valor, suma, promedio, cant;

            suma = 0;
            cant = 0;

            do
            {
                Console.WriteLine("Ingrese un valor para sacar promedio (0 para finalizar)");
                valor = Int32.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            } while (valor != 0);
            if(cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine($"El promedio es: {promedio}");
            }

        }
    }
}
