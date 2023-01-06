namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC C++");
            
            var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            
            var pagedBooks = books.Skip(2).Take(3).Count();
            
            var maximumPrice = books.Max(b => b.Price);
            
            var mininumPrice = books.Min(b => b.Price);
            
            var sumPrices = books.Sum(b => b.Price);

            var averagePrices = books.Average(b => b.Price);
            
            Console.WriteLine(maximumPrice);
            Console.WriteLine(mininumPrice);
            Console.WriteLine(sumPrices);
            Console.WriteLine(averagePrices);
        }
    }
}