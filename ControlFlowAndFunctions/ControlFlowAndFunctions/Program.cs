using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndFunctions
{
     class Program
    {
        static void Main(string[] args)
        {

            // if else statement
            /*Console.Write("Enter your age: ");
            string inputAge = Console.ReadLine();

            int age = Convert.ToInt32(inputAge);

            if(age>=0 && age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age>=13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if(age>=20 && age<=59)
            {
                Console.WriteLine("Adult");
            }
            else if(age>=60)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("age is Invalid");
            }
            
            Console.ReadLine();*/

            // switch case
            //Simple Calculator

            Console.Write("Enter First number: ");
            string inputNum1 = Console.ReadLine();
            int num1 = Convert.ToInt32(inputNum1);

            Console.Write("Enter operator for Calculation: ");
            string inputOperator = Console.ReadLine();

            Console.Write("Enter Second number: ");
            string inputNum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(inputNum2);

            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    Console.WriteLine("Invalid operator you should endter +, - , * or /");
                    break;

            }

            Console.ReadLine();




        }
    }
}
