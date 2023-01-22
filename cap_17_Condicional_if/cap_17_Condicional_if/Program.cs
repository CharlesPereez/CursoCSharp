using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_17_Condicional_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Elige medio de transporte (coche, tren, avion)");
            
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte){
                case "coche":
                    Console.WriteLine("Velocidad media: 100 Km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 180 Km/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;
                default:
                    Console.WriteLine("Medio de transporte incorrecto");
                    break;
            }*/

            Console.WriteLine("Introduce Nro. de mes para calculo de comisión");
            string nMes = Console.ReadLine();

            switch (nMes)
            {
                case "1":
                    Console.WriteLine("Mes seleccionado: Enero");
                    break;
                case "2":
                    Console.WriteLine("Mes selecciondo: Febrero");
                    break;
                case "3":
                    Console.WriteLine("Mes selecciondo: Marzo");
                    break;
                case "4":
                    Console.WriteLine("Mes selecciondo: Abril");
                    break;
                case "5":
                    Console.WriteLine("Mes selecciondo: Mayo");
                    break;
                case "6":
                    Console.WriteLine("Mes selecciondo: Junio");
                    break;
                case "7":
                    Console.WriteLine("Mes selecciondo: Julio");
                    break;
                case "8":
                    Console.WriteLine("Mes selecciondo: Agosto");
                    break;
                case "9":
                    Console.WriteLine("Mes selecciondo: Septiembre");
                    break;
                case "10":
                    Console.WriteLine("Mes selecciondo: Octubre");
                    break;
                case "11":
                    Console.WriteLine("Mes selecciondo: Noviembre");
                    break;
                case "12":
                    Console.WriteLine("Mes selecciondo: Diciembre");
                    break;
                default:
                    Console.WriteLine("Tiene que introducir un numero del 1 al 12");
                    break;
            }


            Console.WriteLine("El programa ha terminado");
        }
    }
}
