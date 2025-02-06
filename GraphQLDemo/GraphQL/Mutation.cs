using GraphQLDemo.Models;
using GraphQLDemo.Repository;

public class Mutation
{
    public Book AddBook(string title, string author) => BookRepository.AddBook(title, author);
}