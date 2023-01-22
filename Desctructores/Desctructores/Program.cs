using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desctructores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.mensaje();

        }
    }

    class ManejoArchivos
    {

        StreamReader archivo = null;


        int contador = 0;

        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"c:\Mensaje.txt");

            while((linea = archivo.ReadLine()) != null)
            {

                Console.WriteLine(linea);
                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} líneas", contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
