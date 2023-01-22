using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_24_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatoreo = numero.Next(0, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("introduce un numero entre 0 y 100");

            do
            {
                intentos++;
                try
                {
                miNumero = Int32.Parse(Console.ReadLine());

                }
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("El número es muy grande o el valor es incorrecto");
                    //Console.WriteLine(ex.Message);
                    miNumero = 0;

                } catch (FormatException ex)
                {
                    Console.WriteLine("No es posible calcular letras");
                    miNumero = 0;
                }

                if (miNumero < numeroAleatoreo) Console.WriteLine("El numero es mas alto");
                if (miNumero > numeroAleatoreo) Console.WriteLine("El numero es mas bajo");

            } while (numeroAleatoreo != miNumero);

            Console.WriteLine($"CORRECTO!! Ocupaste {intentos} intentos");
        }
    }
}
