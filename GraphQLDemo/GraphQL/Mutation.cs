using GraphQLDemo.Models;
using GraphQLDemo.Repository;
using HotChocolate.Subscriptions;

public class Mutation
{
    private readonly BookRepository _repo;

    public Mutation(BookRepository repo)
    {
        _repo = repo;
    }

    public async Task<Book> AddBook(string title, string author, [Service] ITopicEventSender eventSender)
    {
        var newBook = _repo.AddBook(title, author);

        await eventSender.SendAsync("BookAdded", newBook);

        return newBook;
    }
}