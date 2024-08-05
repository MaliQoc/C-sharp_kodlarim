using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            /* customerDal.Add(customer); kısmının altının çizilmesi attribute eklenmesinden kaynaklıdır.
             İmleçle üzerine gelerek uyarıyı görebilirsiniz. */
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    class RequiredPropertyAttribute : Attribute
    {

    }

    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    /* ATTRIBUTES
    .Net Framework' de var olan veya geliştiriciler tarafından yazılan tip veya üyelere 
    çalışma zamanında davranışlarının farklı şekillerde ele alınabilmelerini sağlayan ekstra metadata (veri hakkında veri) bilgileri ekler. */

            /* OBSOLETE
             Kullanıcı veya programcıya bildirim veren özel bir attribute tür. 
            Kodda değişiklik yapmayla alakalı bir takım mesajlar içerir. */
        }