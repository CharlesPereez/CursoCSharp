using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sanción de velocidad 300$", "22-03-2022");


            Console.WriteLine(av2.GetFecha()); 

            av2.MostrarAviso();



        }
    }

}
