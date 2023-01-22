using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    internal class Avion : Vehiculo
    {

        public override void Conducir()
        {
            Console.WriteLine("Volando por los cielos");
        }

        public void Despegar()
        {
            Console.WriteLine("El avion ha despegado");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El avion ha aterrizado");
        }

    }
}
