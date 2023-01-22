using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 });

            //Declaramos el delegado predicado

            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);
            
            foreach(int num in numPares)
            {
                Console.WriteLine(num);
            }

        }
        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

    }
}
