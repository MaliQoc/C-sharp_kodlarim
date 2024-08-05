namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ali";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}