using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Charles";
            p1.Edad = 31;

            Persona p2 = new Persona();
            p2.Nombre = "Charles";
            p2.Edad = 31;

            ComparaPersonas comprarEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comprarEdad(p1.Nombre, p2.Nombre));
            
        }

        public delegate bool ComparaPersonas(String n1, String n2);

    }

    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }

}
