namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        protected int Id { get; set; }
        //private den farklı olarak miras verdiği sınıflarda da kullanılabilir.
        public void Save()
        {
            
        }

        public void Delete()
        {
            
        }
    }

    class Student : Customer
    {
        public void Save2()
        {

        }
    }

    internal class Course
    {
        public string Name { get; set; }
    }

    /* internal olarak tanımlanan öğe, bulunduğu assembly’nin (Dll veya Exe dosyası) içinde erişilebilirdir. 
    Dll veya Exe dosyasının içerisinde erişim için kısıtlama yoktur, ama dışarıdan erişilemez. */
}