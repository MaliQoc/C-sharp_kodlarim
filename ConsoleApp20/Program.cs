﻿namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added.");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int Id,string name)
        {
            _id = Id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        /* ya da public ILogger Logger { get; set; } konulabilirdi. Bu durumda main fonksiyonuna
        EmployeeManager employeeManager = new EmployeeManager();
        employeeManager.Logger = new DatabaseLogger(); yazmamız gerekirdi. */

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added.");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added.");
            Message();
        }
    }

    /* C#'ta static kavramı
     İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir. 
     Metotlar ve alanlar static olarak tanımlanabilir. Static olma durumunun en bilinen örneği Main() metodudur. 
    örneğin student.number = 10 gibi tanımlayabiliriz. */
}