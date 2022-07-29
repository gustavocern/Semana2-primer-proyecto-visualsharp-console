using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_primer_proyecto_visualsharp_console



{
    class calculadora
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 

            switch (op)
            {
                case "s":
                    result = num1 + num2;
                    break;
                case "r":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
               
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine(" Calculadora en C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Escriba un numero y Precione ENTER: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("esta no es una entrada valida porfavor ingrese un numer entero: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Escriba el sieguiente numero y precione ENTER: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("esta no es una entrada valida porfavor ingrese un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                
                Console.WriteLine("Elija un operador de la siguiente lista:");
                Console.WriteLine("\ts - Suma");
                Console.WriteLine("\tr - Resta");
                Console.WriteLine("\tm - Multiplicacion");
                Console.WriteLine("\td - Divicion");
                Console.Write("Selecione una Opcion? ");

                string op = Console.ReadLine();

                try
                {
                    result = calculadora.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operacion matematica da error.\n");
                    }
                    else Console.WriteLine("El resultado es: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("se produjo una excepcion al intetar el calculo .\n - Detalles: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

               
                Console.Write("Precione ENTER para seguir o ´n´ para cerrar la consola: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}




