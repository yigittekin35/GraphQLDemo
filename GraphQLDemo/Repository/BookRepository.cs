using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class BookRepository
    {
        private static List<Book> _books = new()
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell" },
            new Book { Id = 2, Title = "Brave New World", Author = "Aldous Huxley" }
        };

        public static List<Book> GetBooks() => _books;
        public static Book GetBook(int id) => _books.FirstOrDefault(book => book.Id == id);
        public static Book AddBook(string title, string author)
        {
            var newBook = new Book
            {
                Id = _books.Count + 1,
                Title = title,
                Author = author
            };

            _books.Add(newBook);
            return newBook;
        }
    }
}
