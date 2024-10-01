using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if(name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty");
            }

            Console.ReadLine();*/

            /*Console.WriteLine("Check where it is even or odd number");

            Console.Write("Enter the number: ");

            var inputNumber = Console.ReadLine();

            int num  = Convert.ToInt32(inputNumber);

            if(num % 2 == 0)
            {
                Console.WriteLine($"The number that you have gave {num} is Even Number");
            }
            else if(num < 0)
            {
                Console.WriteLine($"The number that you have gave {num} is Negative Number");
            }
            else
            {
                Console.WriteLine($"The number that you have gave {num} is Odd Number");

            }

            Console.ReadLine();*/

           /* var name = "222";

            var anotherName = 222;

            if(name == anotherName)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();*/
            

            object obj = new object();

            object obj1 = new object();

            /*obj = obj1 as object;*/

            if(obj  == obj1)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}
