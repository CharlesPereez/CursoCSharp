using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_67_Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjetoDelegado Saludo = new ObjetoDelegado(MensajeSaludo.saludo);
            ObjetoDelegado Despedida = new ObjetoDelegado(MensajeDespedida.despedida);

            Saludo();   
            Despedida();
        }

        //creacion del delegado
        delegate void ObjetoDelegado();


    }   
    class MensajeSaludo
    {
        public static void saludo()
        {
            Console.WriteLine("Hola!");
        }
    }

    class MensajeDespedida
    {
        public static void despedida()
        {
            Console.WriteLine("Chau!");
        }
    }
}

