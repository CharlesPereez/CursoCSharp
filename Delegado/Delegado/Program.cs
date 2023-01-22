using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion del objeto delegado apuntando al metodo SaludoBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilizacion del delegado para llamar al metodo SaludoBienvenida
            ElDelegado("Hola acabo de llegar");

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado("Adios!");

        }

        //DEfiniciion del objeto delegado

        delegate void ObjetoDelegado(string msj);

    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("mensaje de bienvenida {0}", msj);
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje de despedida: {0}", msj);
        }
    }
}
