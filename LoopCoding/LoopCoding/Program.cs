using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoopCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication of give number
            /*Console.Write("Enter a number you want to multiplication: ");

            var inputString = Console.ReadLine();

            int num = Convert.ToInt32(inputString);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }


            Console.ReadLine();*/

            //Factorial of given number

            /*Console.Write("Enter a number you want to find factorial: ");
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            int total= 1;

            if(num < 0)
            {
                Console.WriteLine("Envalid number please give 0 or above number");
            }else if(num == 0)
            {
                Console.WriteLine("The factorial of given number is 1");
            }
            for(int i = 1; i<= num; i++)
            {

                total *= i;

               
            }
            Console.WriteLine($"The factorial of given number is {total}");
            Console.ReadLine();*/

            //Sum of Even Numbers

            /*Console.Write("Enter the number you want to return even number: ");

            var input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int total = 0;

            for(int i = 1; i<= num; i++)
            {
                if(i % 2 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();*/


            //Reverse String 

            /*Console.Write("Enter the string for reverse");

            string input = Console.ReadLine();

            string reverse = "";

            for(int i = input.Length - 1; i>= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);

            Console.ReadLine();*/


            //Fibonacci Series
            //Write a program to print the first 10 numbers of the Fibonacci series using a for loop.

            /*Console.Write("Enter the number you want to find fibonacci series: ");
            var input = Console.ReadLine();
            int num = Convert.ToInt32(input);


            int n1 = 0;
            int n2 = 1;

            Console.Write($" {n1},{n2}");
            
            for (int i = 0; i < num; i++)
            {
                int n3 = n1 + n2;
                Console.Write($",{n3}");
                n1 = n2;
                n2 = n3;
            }

           Console.ReadLine();*/


            //Task 7: Count Vowels in a String
            //Write a program to count the number of vowels in a given string using a for loop.
            /*Console.Write("Enter the Vowels of string: ");

            string inputString = Console.ReadLine();

            string input = inputString.ToLower();

            string vowel = "aeiou";
            int count = 0;

            //we can also used vowel.contains(input[i]) --contains is a built in built-in method in C# that checks if a string contains a specified character or substring.
            for(int i = 0; i < input.Length ; i++)
            {
                for(int j = 0; j < vowel.Length; j++)
                {
                    if (input[i] == vowel[j]) 
                    {
                        count += 1;
                    }
                }
            }

            Console.WriteLine("The total vowel letter is " + count);


            Console.ReadLine();*/



            //Task 5: Find Prime Numbers
            // Write a program to find all prime numbers between 1 and 100 using a for loop.

            /*



             Task 6: Fibonacci Series

             Task 8: Find Maximum Element
             Write a program to find the maximum element in an array of integers using a for loop.

             Task 9: Sort an Array
             Write a program to sort an array of integers in ascending order using a for loop and any sorting algorithm(e.g., bubble sort).

             Task 10: Print a Pyramid
             Write a program that prints a pyramid pattern of asterisks with a given number of levels using nested for loops.*/

        }
    }
}
