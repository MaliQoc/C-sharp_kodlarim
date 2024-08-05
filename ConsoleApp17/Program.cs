namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database2 = new Oracle();
            database2.Add();
            database2.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

    /* Abstract sayesinde aynı komutu diğer sınıflarda ayrı ayrı kullanabildik. 
    Override işlemini kullanır. Abstract sınıflardan nesne oluşturulamaz.
    Arayüzlerde sadece metot bildirimi yapılabilirken abstract sınıflarda hem metot bildirimi yapılabilir hem de metot tanımlanabilir.*/
}