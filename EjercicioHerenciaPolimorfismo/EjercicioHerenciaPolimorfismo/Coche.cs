using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    internal class Coche : Vehiculo
    {

        public override void Conducir()
        {
            Console.WriteLine("Conduciendo por la ciudad");
        }


        public void Acelerar()
        {
            Console.WriteLine("El coche esta aceleando");

        }

        public void Frenar()
        {
            Console.WriteLine("El coche esta frenando");
        }

    }
}
