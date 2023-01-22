using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoPredicado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Fabricio";
            p1.Edad = 2;

            Personas p2 = new Personas();
            p2.Nombre = "Sergi";
            p2.Edad = 12;

            Personas p3 = new Personas();
            p3.Nombre = "Juana";
            p3.Edad = 23;

            Personas p4 = new Personas();
            p4.Nombre = "Mayra";
            p4.Edad = 15;

            gente.AddRange(new Personas[] { p1, p2, p3, p4 });

            Predicate<Personas> PersonaPred = new Predicate<Personas>(ExistenMayoresEdad);
            
            bool existe = gente.Exists(PersonaPred);

            if (existe) Console.WriteLine("Hay personas mayores de edad");
            else Console.WriteLine("No hay nadie que sea mayor de edad");

        }

        static bool ExistenMayoresEdad(Personas persona)
        {
            if(persona.Edad >= 18) return true;

            else return false;
        }
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
