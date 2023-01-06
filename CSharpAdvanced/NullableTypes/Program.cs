namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;
            DateTime? date3 = date2;

            Console.WriteLine(date2);
            Console.WriteLine(date3);
        }
    }
}