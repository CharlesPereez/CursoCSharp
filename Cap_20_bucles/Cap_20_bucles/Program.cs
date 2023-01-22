using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_20_bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatoreo = numero.Next(0, 100);

            int miNumero = 101;

            int intentos = 0;

            Console.WriteLine("introduce un numero entre 0 y 100");

            while(numeroAleatoreo != miNumero)
            {
                intentos++;
                miNumero = Int32.Parse(Console.ReadLine());
                if (miNumero < numeroAleatoreo) Console.WriteLine("El numero es mas alto");
                if (miNumero > numeroAleatoreo) Console.WriteLine("El numero es mas bajo");

            }
            Console.WriteLine($"CORRECTO!! Ocupaste {intentos} intentos"); 

        }
    }
}
