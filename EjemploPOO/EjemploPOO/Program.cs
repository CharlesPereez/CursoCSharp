using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Circulo miCirculo = new Circulo();

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();


            Console.WriteLine(miCirculo2.CalculoArea(9));*/

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiarValorEuro(1.05);

            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo
    {

        private double pi = 3.1516;

        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }


    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public  double convierte(double cantidad)
        {
            return euro * cantidad;
        }

        public void CambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            else euro = nuevoValor;
        }
    }
}
