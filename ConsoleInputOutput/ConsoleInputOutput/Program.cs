using System;

namespace ConsoleInpuOutput
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Information");

            Console.Write("Enter you Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);

            Console.WriteLine("The name is " + name + " " + "The age is " + age);

            Console.ReadLine();
        }
    }
}