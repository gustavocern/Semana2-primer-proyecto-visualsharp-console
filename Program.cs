using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_primer_proyecto_visualsharp_console



{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0; int num2 = 0;

            
            Console.WriteLine("Console Calculadora en C#\r");
            Console.WriteLine("------------------------\n");

           
            Console.WriteLine("Digite el numero, Precione ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Digite el numero, Precione ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Seleccione la opcion que desea relalizar:");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicacion");
            Console.WriteLine("\td - Divicion");
            Console.Write("cual opcion? ");

           
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"El resultado es : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"El resultado es : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"El resultado es : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"El resultado es : {num1} / {num2} = " + (num1 / num2));
                    break;
            }
           
            Console.Write("Presione ENTER para cerrar la consola");
            Console.ReadKey();
        }
    }
}




