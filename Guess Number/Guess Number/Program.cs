using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number between 1 to 100");
            var inputNum = Console.ReadLine();
            int guessNum = Convert.ToInt32(inputNum);

            Random rnd = new Random();
            var genNum = rnd.Next(0,101);

            if(guessNum > genNum)
            {
                Console.WriteLine("Too High!");
            }else if(guessNum < genNum)
            {
                Console.WriteLine("Too Low!");
            }else if(genNum == guessNum)
            {
                Console.WriteLine("Congratulations! You've guessed the number!");
            }
            Console.WriteLine(genNum);
            Console.ReadLine();
        }
    }
}
