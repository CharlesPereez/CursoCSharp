using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado Charles = new Empleado("Charles");

            Charles.SALARIO = 3500;


            Console.WriteLine($"El salario del empleado es {Charles.SALARIO}");

        }

    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }


        /*public void setSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public double getSalario()
        {
            return salario;
        }*/

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        }

        //CREACION DE PROPIEDAD

        /*public double SALARIO
        {
            get { return this.salario; }

            set { this.salario = evaluaSalario (value); }
        }*/

        public double SALARIO
        {

            get => this.salario;

            set => this.salario = evaluaSalario(value);

        }


        private double salario;

        private string nombre;


    }
     
}
