using System;
class Operator
{
    /* static void Main()
    {
        object i = "50";
        int a = 49;
        string s = i as string;
        Console.WriteLine(s);

        object o = a as object;
        Console.WriteLine(o);
    } */





    /* static void Main()
    {
        byte a = 5 % 3;
        byte b = 5 | 3;
        byte c = 5 ^ 3;
        byte d = 5;
        byte e = (byte)~d;
        byte f = (byte)~(a + b);
        byte g = (byte)~(a + 7);
        Console.WriteLine(a + " " + b + " " + c + " " + e + " " + f + " " + g);
    } */





    /* static void Main()
    {
        byte b = 100;
        byte c = (byte)(b << 1);
        byte d = 50;
        byte e = (byte)(d >> 2);
        Console.WriteLine(c + " " + e);
    } */





    /* static void Main()
    {
        Console.Write("A yı seviyor musunuz? (e,h): ");
        string durum = Console.ReadLine();
        Console.WriteLine(durum == "e" ? "Teşekkürler!!" : "Sağlık olsun...");   
    } */





    /* static void Main()
    {
        int a = 50;
        int b = -a;
        int c = -23;
        int d = -(a + b + c);
        int e = -12;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",a,b,c,d,e);
    } */





    /* static void Main()
    {
        Type a = typeof(int);
        Console.WriteLine(a);
    } */





    /* static void Main()
    {
        int[] dizi = new int[20];
        dizi[5] = 30;
        Console.WriteLine(dizi[5]);
    } */





    /* static void Main()
    {
        int[] dizi = { 3, 2, 6, 7 };
        foreach(int eleman in dizi)
        {
            Console.WriteLine(eleman);
        }
    } */





    /* static void Main()
    {
        int[,,] dizi = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    dizi[i, j, k] = 20;
                }
            }
        }
    } */





    /* static void Main()
    {
        byte b = 7, a = 1, c;
        c = a = b;
        Console.WriteLine(a + " " + b + " " + c);   
    } */

}