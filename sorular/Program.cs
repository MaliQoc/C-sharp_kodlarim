using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        string durum;
        Console.Write("Bir sayi giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir sayi daha giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b && a % 2 == 0)
        {
            durum = "a";
        }
        else if (b > a && b % 2 == 0)
        {
            durum = "b";
        }
        else if (a == b)
        {
            durum = "d";
        }
        else
        {
            durum = "c";
        }

        if (durum == "a" || durum == "b")
        {
            Console.WriteLine("CIFT");
        }
        else if (durum == "c")
        {
            Console.WriteLine("TEK");
        }
        else if (durum == "d")
        {
            Console.WriteLine("ESIT");
        }
    }
}
