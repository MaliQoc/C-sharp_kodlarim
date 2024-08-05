namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("book", "kitap");
            dic.Add("table", "tablo");
            dic.Add("computer", "bilgisayar");

            //Console.WriteLine(dic["table"]);
            //Console.WriteLine(dic["glass"]);

            foreach (var item in dic)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine("\n");
            }

            Console.WriteLine(dic.ContainsKey("glass"));
            Console.WriteLine(dic.ContainsKey("table"));
        }
    }
}