/* 1- FOR DÖNGÜLERİ
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("AFERIN");
        }
    }
} */





/* 2- WHILE DÖNGÜLERİ
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("New number is {0}", num);
            Console.ReadLine();
        }
    }
} */





/* 3- DO WHILE DÖNGÜLERİ
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num <= 100);
            Console.ReadLine();
        }
    }
} */





namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Ali", "Ayşe", "Fatma" };
            foreach (var student in students)
            {
                // foreach ile yazdırdığımız elemanları foreach ın içinden değiştiremeyiz.
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}