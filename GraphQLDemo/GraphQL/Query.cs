using GraphQLDemo.Models;
using GraphQLDemo.Repository;

public class Query
{
    public List<Book> GetBooks() => BookRepository.GetBooks();
    public Book GetBook(int id) => BookRepository.GetBook(id);
}