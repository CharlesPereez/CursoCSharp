using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor, 
             indica que ha finalizado la carga). Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
            int valor, suma;

            suma = 0;
                                   
            do
            {
                Console.WriteLine("Ingrese los valores a sumar (escriba 9999 para finalizar)");
                valor = Int32.Parse(Console.ReadLine());
                if (valor != 9999)  suma = suma + valor;
                

            } while (valor != 9999);

            Console.WriteLine($"El valor acumulado es: {suma}");

            if (suma < 0) Console.WriteLine($"{suma} es menor que cero");
            else if (suma > 0) Console.WriteLine($"{suma} es mayor que cero");
            else Console.WriteLine("El valor es cero");
        }
    }
}
