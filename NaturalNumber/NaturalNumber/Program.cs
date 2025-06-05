

namespace NaturalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want to find sum of 5 and 3 multiple: ");
            string input = Console.ReadLine();
            int number= int.Parse(input);

            int count = 0;

            for(int i = 1; i< number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    count = count + i;
                }
            }

            Console.WriteLine("Sum of 5 and 3 multiple is: " + count);


        }
    }
}