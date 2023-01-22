using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    internal class Vehiculo
    {

        public virtual void Conducir()
        {
            Console.WriteLine("Metodo genérico de conducir");
        }

        public void ArrancarMotor(String sonidoArrancar)
        {
            Console.WriteLine($"El motor esta encendido {sonidoArrancar}");
        }

        public void ApagarMotor(String sonidoApagar)
        {
            Console.WriteLine($"El motor esta apagado {sonidoApagar}");
        }

              
    }
}
