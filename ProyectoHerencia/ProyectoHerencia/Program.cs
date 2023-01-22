using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Caballo Babieca = new Caballo("Babieca");
            Humano Charles = new Humano("Charles");
            Gorila Copito = new Gorila("Copito");

            ISaltoConPatas ImiBanieca = Babieca;

            //Charles.getNombre();

            //Babieca.getNombre();

            //Copito.getNombre();

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine($"Para utilizadas por saldo de Babieca {ImiBanieca.numeroPatas()}");*/


            Lagartija juancho = new Lagartija("Juancho");

            juancho.getNombre();

            Humano Charles = new Humano("Charles");

            Charles.getNombre();

        }
    }


    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }

    class Lagartija : Animales
    {
        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil}");
        }

        private String nombreReptil;
    }


    class Mamiferos : Animales
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico Instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Ciudo de mis crias");
        }

        public override void getNombre()
        {
            Console.WriteLine($"El nombre del mamífero es: {nombreSerVivo}");
        }
        private String nombreSerVivo;
    }

    interface IMamiferosTerrestres
    {

        int numeroPatas();

    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {

        int numeroPatas();

    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }

    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }



    sealed class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public int numeroPatas()
        {
            return 2;
        }
        public override void pensar()
        {
            Console.WriteLine("Pensamiento Insntitivo Avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

}
