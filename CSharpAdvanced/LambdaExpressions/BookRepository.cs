using Generics;

namespace LambdaExpressions;

public class BookRepository
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "Title1", Price = 5 },
            new Book() { Title = "Title2", Price = 7 },
            new Book() { Title = "Title3", Price = 17 }

        };
    }
}