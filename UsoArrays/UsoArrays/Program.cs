using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array implicito

            //var datos = new[] { "Charles", "Perez", 15 };

            var valores = new[] { 15, 34.4, 31, 5.6 };

            //Arrays de objetos

            Empleados Mayra = new Empleados("Mayra", 35);
            
            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Charles", 31);

            arrayEmpleados[1] = Mayra;

            arrayEmpleados[2] = new Empleados("Fabricio", 12);




            //Array de tipos o clases anonimas

            var personas = new[]
            {
                new{Nombre = "Juan", Edad= 26},

                new{Nombre = "Charles", Edad= 21},

                new{Nombre = "Juana", Edad= 35}
            };



            /*for (int i = 0; i < arrayEmpleados.Length; i++)

            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }

            foreach(double variable in valores)
            {
                Console.WriteLine(variable);
            }

            foreach (var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }

    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return "Nombre del Empleado " + nombre + " Edad: " + edad;
        }

        private String nombre;
        private int edad;
    }
}
