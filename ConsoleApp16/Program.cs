namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default.");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code.");
            base.Add(); //base.Add koyduğumuzda override işlemi gerçekleşmeyecek ve miras alınan sınıfın komutu çalışacak.
        }
    }

    class MySql : Database
    {

    }
}

/* Virtual bir sınıfın miras alınan sınıflardaki metodunun ezilebilmesini, değişebilmesini sağlar.
Override ise miras alınan metodun ezilmesi işlemini sağlar, yani amaç metodun içini değiştirmektir. */