using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> edades = new Dictionary<string, int>();

            //rellenar el diccionario

            edades.Add("Charles", 31);

            edades.Add("Fabricio", 1);

            edades["Sergi"] = 12;
            
            edades["Mayra"] = 35;

            //recorrer diccionario

            foreach(KeyValuePair<string,int> personas in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1}", personas.Key, personas.Value);
            }
        }
    }
}
