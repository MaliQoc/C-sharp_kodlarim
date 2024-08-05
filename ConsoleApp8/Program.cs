/* namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] students = new string[3] { "Engin", "Ali", "Yiğit" };
            students[0] = "Engin";
            students[1] = "Ali";
            students[2] = "Yiğit";  aşağıdaki de aynıdır. */

            /* string[] students2 = { "Engin", "Ali", "Yiğit" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
} */



namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[7, 3]
            {
                {"İstanbul","Bursa","Tekirdağ"},
                {"Ankara","Konya","Sivas"},
                {"İzmir","Manisa","Aydın"},
                {"Trabzon","Samsun","Giresun"},
                {"Adana","Antalya","Mersin"},
                {"Diyarbakır","Şanlıurfa","Gaziantep"},
                {"Tunceli","Erzurum","Kars"}
            };

            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadLine();
        }
    }
}