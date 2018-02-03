using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso de Variables
            Console.WriteLine("-----Declaracion de Variables y como imprimirlas----");
            int calif;
            int numero = 3;
            string myText;

            calif = 70;
            System.Console.WriteLine(calif);
            myText = "Hola!";
            System.Console.WriteLine(myText);
            calif = 90;
            System.Console.WriteLine(calif);

            //Estructura Condicional If
            Console.WriteLine("--------Uso de Condicional If------");
            if (calif >= 90)
                Console.WriteLine("A");
            else
                if (calif >= 80)
                    Console.WriteLine("B");
                else
                    if (calif >= 70)
                        Console.WriteLine("C");
                    else
                        if (calif >= 60)
                            Console.WriteLine("D");
                        else
                            Console.WriteLine("F");
            Console.WriteLine("----------------------");

            //Estructura Condicional Switc

            Console.WriteLine("------Uso de Condicional Switch-----");
            switch (calif)
            {
                case 10:
                    Console.WriteLine("diez");
                    break;
                case 20:
                    Console.WriteLine("veinte");
                    break;
                case 30:
                    Console.WriteLine("treinta");
                    break;
                case 40:
                    Console.WriteLine("cuarenta");
                    break;
                case 90:
                    Console.WriteLine("noventa");
                    break;
                default:
                    Console.WriteLine("otro");
                    break;
            }

            Console.WriteLine("----------------------");

            //Estructura repetitiva While
            Console.WriteLine("----Estructura Repetitiva While----");
            while (numero <= 100)
            {
                numero = 3 * numero;
                Console.WriteLine(numero);
            }
            Console.WriteLine("----------------------");

            //Estructura Repetitiva For
            Console.WriteLine("-----Estructura Repetitiva For----");
            for (numero = 5; numero <= 15; numero = numero + 1)
                Console.WriteLine(numero);

            Console.WriteLine("----------------------");

            //Estructura Repetitiva Do While
            Console.WriteLine("-----Estructura Repetitiva Do While---");
            numero = 1;
            do
            {
                Console.WriteLine(numero);
                numero = numero + 1;
            }
            while (numero <= 12);
            Console.ReadKey();
            

        }
    }
}
