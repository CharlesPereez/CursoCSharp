using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struck_y_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Charles = new Empleado(Bonus.extra, 2200);

            Console.WriteLine($"El salario del empleado Charles es: {Charles.getSalario()}");


        }
    }

    class Empleado
    {

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;

            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + (double)bonusEmpleado;
        }

        private double salario;

        private Bonus bonusEmpleado;

    }



    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };

}
