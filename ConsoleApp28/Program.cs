namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for(int i = 0; i < 5; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
            }
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!");
        }

        /* OLAYLAR(EVENTS)
         Olaylar, nesne yönelimli programlama ortamlarında devamlı olarak kullanılırlar. 
        Burada en çok bilinen örnek, button sınıfına ait olan bir nesne için click isimli eventdir. 
        Click eventinde fareyle button nesnesinin üzerine tıklandığında ortama bir olay fırlatılır. 
        Ayrıca, olaylar veritabanındaki Trigger(tetikleyici)‘lar gibi düşünülebilir. 
        Olaylar program içinde gerekli şartlar sağlandığında kendiliğinden gerçekleşirler. Çağırılmalarına gerek yoktur. Metodlardan bu noktada farklıdırlar.
        Olaylar kullanılacağı zaman bunu gerçekleştirmek için temsilcilere başvurulur. Olaylar temsilci türünden yaratılarak ortama fırlatılabilir. */

    }
}