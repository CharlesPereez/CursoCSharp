using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_24_UsoChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = int.MaxValue;

            int resultado = checked(numero + 20);

            Console.WriteLine(resultado);
            
        }
    }
}
