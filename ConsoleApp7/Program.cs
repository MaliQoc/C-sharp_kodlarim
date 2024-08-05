namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2,int num3)
        {
            return num1 * num2 * num3;
        }

        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}