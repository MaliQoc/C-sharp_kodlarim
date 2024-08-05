using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            long num3 = 47394495490;
            float num4 = 10.4f; // ya da 10.4 (7 basamak)
            double num5 = 10.4d; // ya da 10.4 (16 basamak)
            decimal num6 = 10.4m; // ya da 10.4 (29 basamak)
            byte num7 = 250;
            short num8 = 32500;
            char a = 'a';
            string b = "ali";
            var num9 = 100;
            num9 = 'D';

            Console.WriteLine("numbers are {0},{1}", num1, num2);
            Console.WriteLine("number is {0}", num3);
            Console.WriteLine("number is {0}", num4);
            Console.WriteLine("number is {0}", num5);
            Console.WriteLine("number is {0}", num6);
            Console.WriteLine("number is {0}", num7);
            Console.WriteLine("number is {0}", num8);
            Console.WriteLine("character is {0}", a);
            Console.WriteLine("name is {0}", b);
            Console.WriteLine("number is {0}", num9);
            Console.WriteLine(days.tuesday);
            Console.WriteLine((int)days.tuesday);
            Console.WriteLine(int)days.tuesday + 1);
            Console.ReadLine();
        }
    }
    enum days
    {
        monday,tuesday,wednesday,thursday,friday,saturday,sunday
    }
}
