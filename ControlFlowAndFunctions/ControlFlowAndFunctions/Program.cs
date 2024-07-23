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
            Console.Write("Enter your age: ");
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
            
            Console.ReadLine();

            // switch case
        }
    }
}
