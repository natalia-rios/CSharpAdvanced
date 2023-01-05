using Generics;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // number => number * number;

            // No argument: () => ...
            // Only one argument: x => ...
            // Multiple arguments: (x, y, z) => ...

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}