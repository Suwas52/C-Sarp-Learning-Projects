using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string textInt = "-23";
            int intData = Convert.ToInt32(textInt);

            Console.WriteLine(intData);

            string textLong = "-23142345";
            long longData = Convert.ToInt64(textLong);
            
            Console.WriteLine(longData);

            string textFloat = "-24234.234";
            float floatData = Convert.ToSingle(textFloat);
            Console.WriteLine(floatData);

            string textMoney = "12.88";
            decimal money = Convert.ToDecimal(textMoney);

            Console.WriteLine(money);



            //var keyword

            var dataInt = 122;
            var dataString = "subash";
            Console.WriteLine(dataInt);
            Console.WriteLine(dataString);

            //Const keyword
            //const keyword means constant variable which cannot be change in future

            const int fixValue = 23;

            Console.WriteLine(fixValue);



            //exercise

            string name = "Subash";
            string PhoneNumber = "07798080234823";
            int age = 24;

            Console.WriteLine(name);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(age);

            var calculate = 2324;
            Console.WriteLine(calculate.GetType());

            //Check even or odd

            var inputData = 27;

            if(inputData % 2 == 0)
            {
                Console.WriteLine("The given data is Even");
            }
            else
            {
                Console.WriteLine("The given data is Odd");
            }
            Console.ReadLine();

        }
    }
}
