using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlamcenaObjetos<DateTime> archivos = new AlamcenaObjetos<DateTime>(4);

            /*archivos.agregar("Charles");
            archivos.agregar("Mayra");
            archivos.agregar("Sergi");
            archivos.agregar("Fabricio");*/

            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime()); 
            archivos.agregar(new DateTime());
            

            DateTime nombrePersona = archivos.getElemento(0);
            Console.WriteLine(nombrePersona);

        }
    }

    class AlamcenaObjetos<T>
    {

        public AlamcenaObjetos(int z)
        {

            datosElemento = new T[z];

        }

        public void agregar( T obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }
}
