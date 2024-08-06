namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // customerManager.SendMessage();
            // customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");
            myDelegate();

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Topla;

            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

        }
    }
     
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine("Be careful!");
        }
    }

    public class Matematik
    {
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Carp(int number1, int number2)
        {
            return number1 * number2;
        }
    }

    /* DELEGATES
    C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.
    C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.
    Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur.
    Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız. */
}
