using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Probando el avion");

            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("FuuuuuFuuuuFuuuuuu");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.ApagarMotor("Ploooof");

            Console.WriteLine("******************************************************");

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancarMotor("Fruuuuuuuummmm");

            miCoche.Conducir();

            miCoche.Acelerar();

            miCoche.Frenar();

            miCoche.ApagarMotor("Clic");

            Console.WriteLine("******************************************************");


            Console.WriteLine("Polimorfismo en acción");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();


        }

    }

}
