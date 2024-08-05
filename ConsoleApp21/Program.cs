using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("İstanbul");
            cities.Add("Ankara\n");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<string> apples = new List<string>();
            apples.Add("Red");
            apples.Add("Green");
            apples.Add("Yellow\n");

            foreach (var apple in apples)
            {
                Console.WriteLine(apple);
            }

            /* List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            customers.Add(new Customer { Id = 2, FirstName = "Derin" }); yapabiliriz */

            // ya da şunu yapabiliriz.

            List<Customer> customers = new List<Customer>();
            {
                new Customer { Id = 1, FirstName = "Engin" };
                new Customer { Id = 2, FirstName = "Derin" };
            }
            
            var count = customers.Count();
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Taha"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName = "Gizem"},
                new Customer{Id = 5, FirstName = "Ali"}
            });

            // customers.Clear();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.WriteLine("Count: {0}", count);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}