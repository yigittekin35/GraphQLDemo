using GraphQLDemo.Models;
using GraphQLDemo.Repository;

public class Query
{
    private readonly BookRepository _repo;
    public Query(BookRepository repo)
    {
        _repo = repo;
    }

    public List<Book> GetBooks() => _repo.GetBooks();
    public Book GetBook(int id) => _repo.GetBook(id);
}