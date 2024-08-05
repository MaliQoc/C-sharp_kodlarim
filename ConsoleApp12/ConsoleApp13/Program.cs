using System.Net.Http.Headers;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        // public string FirstName { get; set; }

        private string _FirstName;
        public string FirstName
        {
            get { return "Mr." + _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added.");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
    class Program
    {
        public void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Ali", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
