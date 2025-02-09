using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL;

public class Subscription
{
    [Subscribe]
    [Topic("BookAdded")]
    public Book OnBookAdded([EventMessage] Book book) => book;
}
