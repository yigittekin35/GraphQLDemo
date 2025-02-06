using GraphQLDemo.Models;
using GraphQLDemo.Repository;

public class Mutation
{
    private readonly BookRepository _repo;

    public Mutation(BookRepository repo)
    {
        _repo = repo;
    }

    public Book AddBook(string title, string author) => _repo.AddBook(title, author);
}