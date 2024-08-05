class Alan
{
    static void Main()
    {
        Console.Write("En giriniz: ");
        int en = Convert.ToInt32(Console.ReadLine());

        Console.Write("Boy giriniz: ");
        int boy = Convert.ToInt32(Console.ReadLine());

        int result = Dikdortgen(en, boy);
        Console.WriteLine("Alan: " + result);
    }

    static int Dikdortgen(int a,int b)
    {
        int result = a * b;
        return result;
    }
}
