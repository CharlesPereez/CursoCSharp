using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCochePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Coche coche1 = new Coche(); //Crear objeto de tipo coche - Dar un estado inicial a nuestro coche


            Coche coche2 = new Coche(2.3, 1.5);

            Console.WriteLine(coche2.getRuedas());
            coche2.setExtras(true, "Cuero");
            Console.WriteLine(coche2.getExtras());


        }
    }

    partial class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";

        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        } 
    }




    /*----------------------------------------------------------------------------------------------*/




    partial class Coche { 
        public String getRuedas()
        {
            return "Información del coche: \n" + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }


        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {
            return "Extras del coche: \n " + "Tapicerpía: " + tapiceria + " Climatizador: " + climatizador;
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
