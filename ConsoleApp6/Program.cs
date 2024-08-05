/* namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 100;
            var result = Add(num1, num2);
            Console.WriteLine(result);
            Console.WriteLine(num1);
        }

        static int Add(int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }
    }
}

  sonuç burada 130 ve 20 olur. */

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 80;
            var result = Add(ref num1, ref num2);
            Console.WriteLine(result);
            Console.WriteLine(num1);
        }

        static int Add(ref int num1, ref int num2)
        {
            num1 = 10;
            num2 = 60;
            return num1 + num2;
        }
    }
}

// sonuç burada 70 ve 10 olur.
// yukardaki ve aşağıdaki num1 değerleri
// normalde birbiriyle aynı değildir.
// ref komutunu kullandırarak num1 in her iki tarafta da
// referans değerlerini vermesini sağlarız.
// burada add fonksiyonunun içindeki değerleri
// ref komutuyla referans alıp onlarla işlem yaptık.
// yukarıdaki num1 ve num2 ler işleme alınmadı.



/* OUT KULLANIMI
   C# içerisinde yer alan ref ve out anahtar kelimeleri aynı işlemi yapar. 
   Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken 
   out anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur. */
