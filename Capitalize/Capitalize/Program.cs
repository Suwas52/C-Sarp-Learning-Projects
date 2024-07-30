using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge-- Capitalize each word in a string
            Console.WriteLine("Enter sentence for capitalize each word");
            string inputWord = Console.ReadLine();

            string[] stringArr = inputWord.Split(' ');

            

            Console.WriteLine(stringArr.Length);
            Console.ReadLine();
        }
    }
}
