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
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculadora en C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Digite el numero, Precione ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Digite el numero, Precione ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Seleccione la opcion que desea relalizar:");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicacion");
            Console.WriteLine("\td - Divicion");
            Console.Write("cual opcion? ");

            // Use a switch statement to do the math.
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
            // Wait for the user to respond before closing.
            Console.Write("Presione ENTER para cerrar la consola");
            Console.ReadKey();
        }
    }
}




