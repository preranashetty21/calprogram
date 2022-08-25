using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_program_
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                try { 
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option:");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.Write("Enter an option: ");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine("Your result : {num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine("Your result : {num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine("Your result : {num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine("Your result : {num1} / {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("That was not a valid option");
                            break;
                    }
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message); 
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No) = ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadLine();
        }
    }
}
