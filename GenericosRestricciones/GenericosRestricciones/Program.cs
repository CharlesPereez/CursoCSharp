using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlamacenEmpleados<Director> empleados = new AlamacenEmpleados<Director>(3);

            empleados.agregar(new Director(4500));
            empleados.agregar(new Director(1500));
            empleados.agregar(new Director(2000));


        }
    }


    class AlamacenEmpleados<T> where T : IParaEmpleados
    {
        public AlamacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void agregar(T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleados[i];
        }


        private int i = 0;

        private T[] datosEmpleados;

    }

    class Estudiante
    {

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {

            return edad;
        }

        private double edad;
    }
    class Director : IParaEmpleados
    {
        public Director(double salario)
        {

            this.salario = salario;

        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {

        public Secretaria(double salario)
        {

            this.salario = salario;

        }

        public double getSalario()
        {
            return salario;
        }
        private double salario;
    }

    class Electricista : IParaEmpleados
    {
        public Electricista(double salario)
        {

            this.salario = salario;

        }

        public double getSalario()
        {
            return salario;
        }
        private double salario;

    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}



