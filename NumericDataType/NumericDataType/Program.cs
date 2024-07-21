using System;

namespace NumericDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;
            long phoneNum = 9808082349;

            double mydoubleNum = 23.3D;
            char letter = 'A';

            bool check = false;
            float floatNum = 123123333f;

            decimal decimalNum = 22.5M;
            string name = "subash";



            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(check);
            Console.WriteLine(decimalNum);
            Console.WriteLine(letter);
            Console.WriteLine(decimal.MaxValue);


            // Calculate the Area of a Circle

            float pi = 3.14159f;

            float r = 2.3f;

            float Area;

            Area = pi * (r * r);

            Console.WriteLine("Area of the Circle: " + Area);




            // Convert Temperature from Celsius to Fahrenheit

            float celcius = 34;

            float Fahrenheit;

            Fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine(Fahrenheit);


            //Find the Maximum and Minimum of Three Numbers

            int a = 2, b = 9, c = 3;

            if (a < b && a < c)
            {
                Console.WriteLine("Minimum number is :" + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Minimum number is :" + b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("Minimum number is: " + c);
            }

            if (a > b && a > c)
            {
                Console.WriteLine("Maximum number is :" + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Maximum number is :" + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Maximum number is: " + c);
            }


            //Calculate Simple Interest

            float principle = 1000, rate = 5.5f, time = 2;

            float simpleInterest;

            simpleInterest = (principle * rate * time) / 100;


            Console.WriteLine("The calculation of SI is: " + simpleInterest);

            //Sum of Digits of a number

            int inputNum = 12312423;

            int sum = 0;

            while(inputNum > 0)
            {
                sum += inputNum % 10;
                inputNum /= 10;
            }

            Console.WriteLine("The Sum of Digit: "+ sum);
            Console.ReadLine();

        }
    }
}
