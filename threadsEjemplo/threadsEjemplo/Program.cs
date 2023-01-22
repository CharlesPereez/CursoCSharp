using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadsEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            CuentaBancaria cuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersona = new Thread[15];


            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(cuentaFamilia.VamosRetirarEfectivo);

                t.Name = i.ToString();

                hilosPersona[i] = t;


            }




            for (int i = 0; i < 15; i++)
            {
                hilosPersona[i].Start();
                hilosPersona[i].Join();
            }


        }


    }

    class CuentaBancaria
    {

        public Object BloqueSaldoPositivo = new object();
        double saldo { get; set; }
        public CuentaBancaria(double Saldo)
        {
            this.saldo = Saldo;
        }

        public double retirarEfectivo(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                Console.WriteLine("Saldo Insuficiente");
            }

            //lock (BloqueSaldoPositivo)
            //{
                if (saldo >= cantidad)
                {
                    Console.WriteLine("Retirado {0} queda {1} en la cuenta {2}", cantidad, (saldo - cantidad), Thread.CurrentThread.Name);
                    saldo -= cantidad; //saldo = saldo - cantidad
                }

                return saldo;
            }
        //}

        public void VamosRetirarEfectivo()
        {

            Console.WriteLine("Esta sacando dinero el hilo: {0}", Thread.CurrentThread.Name);

            for (int i = 0; i < 4; i++) retirarEfectivo(500);
        }

    }
}


