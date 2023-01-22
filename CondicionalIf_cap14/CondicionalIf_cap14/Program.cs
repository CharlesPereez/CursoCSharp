using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalIf_cap14
{

    /*
     ***** OPERADORES DE COMPARACION *******
    == igual que
    != difrente que
    < menor que
    <= menor o igual que
    > mayor que
    >= mayor o igual que
        

    ***** OPERERADORES LOGICOS ******
    && Y logico
    || O logico 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Vamos a evaluar si puede conducir vehiculos");

            //bool carnet = true;

            //if(carnet)
            //    Console.WriteLine("Felicidades! Puedes conducir");
            //else
            //    Console.WriteLine("Lo siento, No puedes conducir vehiculos");

            /* ********************************************************************************************

            Console.WriteLine("Vamos a verificar si eres mayor de edad");

            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18) Console.WriteLine("Eres mayor de edad");
            else Console.WriteLine("Eres menor de edad");
            */

            /* ******************************************************************************************** */

            /*string carnet = "no";
            
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet de conducir?");
                carnet = Console.ReadLine();

            }

            if(edad >= 18 && carnet == "si")
                Console.WriteLine("Felicidades, puedes conducir");

            else
                Console.WriteLine("Lo siento, no puede conducir");*/


            /* ************************************************************************** */

            /* Console.WriteLine("Vamos a evaluar si puede conducir vehiculo");

             Console.WriteLine("Ingrese su edad");
             int edad = int.Parse(Console.ReadLine());

             if (edad < 18) Console.WriteLine("No puede conducir vehiculo");
             else
             {
                 Console.WriteLine("¿Tienes carnet de conducir?");

                 string carnet = Console.ReadLine();

                 int compara = string.Compare(carnet, "si", true);

                 if (compara == 0) Console.WriteLine("Puede conducir");

                 else Console.WriteLine("No puede conducir");

             } */


            /*Console.WriteLine("Ingresa el primer parcial");
            float parcial1 = int.Parse(Console.ReadLine());   
            
            Console.WriteLine("Ingresa el segundo parcial");
            float parcial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer parcial");
            float parcial3 = int.Parse(Console.ReadLine());

            if(parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            {
                Console.WriteLine("La nota es: " + (parcial1 + parcial2 + parcial3) / 3);
            }*/

            /* EJERCICIO 1
             * Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo 
             * informar su suma y diferencia, en caso contrario informar el producto y la división del 
             * primero respecto al segundo. */

            /*Console.WriteLine("Ingresa el primer numero");
            int primerValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int segundoValor = int.Parse(Console.ReadLine());

            if (primerValor > segundoValor)
            {
                Console.WriteLine($"La suma es: {primerValor + segundoValor}");
                Console.WriteLine($"La resta es: {primerValor - segundoValor}");
            }
            else
            {
                Console.WriteLine($"La multiplcación es: {primerValor * segundoValor}");
                Console.WriteLine($"La divisíon es: {primerValor / segundoValor}");

            }
            Console.WriteLine("Programa Finalizado");*/

            /* EJERCICIO 2
             Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado".
             */

            /*Console.WriteLine("Primera nota");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercera nota");
            int num3 = int.Parse(Console.ReadLine());

            int promedio = (num1 + num2 + num3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("PROMOCINADO!!");
            }
            else
            {
                Console.WriteLine("Nos vemos en Septiembre, NO HAS APROBADO!");
            }*/

            /* EJERCICIO 3
             Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.
                (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
             */
            /*Console.WriteLine("Ingrese un número positivo");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero < 10) Console.WriteLine("El numero ingresado tiene un digitos");
            if (numero >= 10 && numero < 100) Console.WriteLine("El numero ingresado tiene dos digitos");

            Console.WriteLine("Programa finalizado");*/

            /* EJERCICIO 
             Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
             */

            /* Console.WriteLine("Ingresa el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer numero");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} es el mayor");
            }
            else
            {
                if (num2 > num1 && num2 > num3) 
                { 
                Console.WriteLine($"{num2} es el mayor");
                }
                else
                {
                    Console.WriteLine($"{num3} es el mayor");

                }

            }*/

            /* EJERCICIO
             Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo.
             */

            /*Console.WriteLine("Ingresa un valor");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("En valor es NULO");
            } else
            {
                if(valor > 0)
                {
                    Console.WriteLine("En valor es POSITIVO");

                }
                else
                {
                    Console.WriteLine("En valor es NEGATIVO");

                }
                Console.ReadKey();
            }*/


            /* EJERCCIO
            Confeccionar un programa que permita cargar un número 
            entero positivo de hasta tres cifras y muestre un mensaje indicando si tiene 1, 2, o 3 cifras. 
            Mostrar un mensaje de error si el número de cifras es mayor.
             */

            /*Console.WriteLine("Ingresa un numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10) Console.WriteLine($"El numero {numero} tiene una cifra");

            else if (numero >= 10 && numero < 100) Console.WriteLine($"El numero {numero} tiene dos cifras");

            else if (numero >= 100 && numero < 1000) Console.WriteLine($"El numero {numero} tiene tres cifras");

            else if(numero > 1000) Console.WriteLine("ERROR! el numero tiene mas de 4 cifras"); */

            /* EJERCICIO
             *Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: 
             *cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente. 
             *Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del mismo según 
             *el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
	            Nivel máximo:	Porcentaje>=90%.
	            Nivel medio:	Porcentaje>=75% y <90%.
	            Nivel regular:	Porcentaje>=50% y <75%.
	            Fuera de nivel:	Porcentaje<50%. 
             */

            Console.WriteLine("Ingrese la cantidad de preguntas");
            int cantidadPreguntas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de respuestas correctas");
            int respuestasCorrectas = int.Parse(Console.ReadLine());

            int porcentaje = cantidadPreguntas * respuestasCorrectas / 100;

            if (porcentaje >= 90) Console.WriteLine("Nivel MAXIMO");
            else if (porcentaje >= 75 && porcentaje < 90) Console.WriteLine("Nivel Medio");
            else if (porcentaje >= 50 && porcentaje < 75) Console.WriteLine("Nivel Regular");
            else Console.WriteLine("Fuera de Nivel :(");
        }



    }


}


