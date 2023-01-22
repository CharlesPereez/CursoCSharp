using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_DoWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: número de cuenta y saldo actual. 
             * El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            Estado de la cuenta	        'Acreedor' si el saldo es >0.
			                            'Deudor' si el saldo es <0.
			                            'Nulo' si el saldo es =0.
            b) La suma total de los saldos acreedores.*/

            int cuenta;
            float saldo, suma;
            suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero de cuenta");
                cuenta = Int32.Parse(Console.ReadLine());
                if (cuenta >= 0)
                {
                    Console.WriteLine("Ingrese el Saldo");
                    saldo = float.Parse(Console.ReadLine());
                    if (saldo > 0)
                    {
                        Console.WriteLine("Saldo acreedor");
                        suma = suma + saldo;
                    }
                    else if (suma < 0) Console.WriteLine("Saldo deudor");
                    else Console.WriteLine("NULO");

                }
            } while (cuenta >= 0);
            Console.WriteLine($"TOTAL DE SALDOS ACREEDORES: {suma}");
            
        }
    }
}
