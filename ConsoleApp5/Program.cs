using System;
using System.ComponentModel;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            var result = Add2(20,30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added !");
        }

        static int Add2(int num1 , int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}
// ÖNEMLİ:  ya da static int Add2(int num1 = 20 , int num2 = 30) ve var result = Add2(); yapabiliriz.



/* ÖNEMLİ:  static int Add2(int x, int num1 = 20 , int num2 = 30)
{
    var result = num1 + num2;
    return result;
} yapıyorsak yukarıda var result = Add2(); burası boş kalmamalı içine değer vermeliyiz. */

