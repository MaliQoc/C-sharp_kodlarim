namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Customer : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Product : IEntity
    {

    }

    interface ICustomerDal : IRepository<Product>
    {
        void Custom();
    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    /* GENERICS
     Generic'ler tasarlandığımız interface, class, metod yada parametrelerin (argümanların) 
     belirli bir tip için değil bir şablon yapısına uyan her tip için çalışmasını sağlayan bir yapıdır. 
    Yazılım parçacıkları içerisinde tekrar kullanılabilir kod yazmamıza yardımcı olarak kod tekrarını önler. 
    Çalışma zamanında (run time) gereksiz Cast ve Boxing-Unboxing kullanmasını önlediğinden efektif performans sağlar. */
}