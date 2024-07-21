using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the length you want to generate: ");

            string InputLength = Console.ReadLine();

            int passwordLength = Convert.ToInt32(InputLength);



            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZaabcdefghijklmnopqrstuvwxyz0123456789@#$%&";

            string genPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int rndDigit = rnd.Next(0, chars.Length-1);
                var genChar = chars[rndDigit];
                genPassword += genChar;
                
            }

            /*Console.WriteLine(rnd.Next());*/

            Console.WriteLine(genPassword);


            Console.ReadLine();
        }
    }
}
