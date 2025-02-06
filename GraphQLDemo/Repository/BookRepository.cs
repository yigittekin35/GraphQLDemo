using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class BookRepository
    {
        private List<Book> _books = new();

        public List<Book> GetBooks() => _books;
        public Book GetBook(int id) => _books.FirstOrDefault(book => book.Id == id);
        public Book AddBook(string title, string author)
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
