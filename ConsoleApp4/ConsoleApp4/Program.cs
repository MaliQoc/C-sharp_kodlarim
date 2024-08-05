using System.Diagnostics;
/* 1- if konusu
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }
            Console.ReadLine();
        }
    }
} */





/* 2- if else konusu (? ve : ile)
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            Console.ReadLine();
        }
    }
} */





/* 3- else if konusu
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            Console.ReadLine();
        }
    }
}
 (var değerini 10 veya 20 den başka bir şey yaparsak ve else bloğunu kaldırıyorsak kod boş değer verecektir.) */





/* 4- switch case konusu
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadLine();
        }
    }
} */





/* 5- çoklu şartlarla çalışma (&& ve ||)
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 and 100.");
            }
            else if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 100 and 200.");
            }
            else if (number >= 0 || number <= 100)
            {
                Console.WriteLine("Number is less than 0 or greater than 200.");
            }
            Console.ReadLine();
        }
    }
} */