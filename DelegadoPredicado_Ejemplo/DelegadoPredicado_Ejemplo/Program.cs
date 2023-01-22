using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoPredicado_Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numero = new List<int>();

            numero.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 3, 7, 15, 20, 5 });

            Predicate<int> pred = new Predicate<int>(Rango);

            List<int> numPares = numero.FindAll(pred);

            foreach (int n in numPares)
            {
                Console.WriteLine(n);
            }


            numero.RemoveAll(pred);

            Console.WriteLine("------------------");

            foreach (int num in numero)
            {
                Console.WriteLine(num);
            }

        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;

        }

        static bool Rango(int num)
        {
            if (num >= 3 && num <= 7) return true;
            else return false;

        }
    }
}
