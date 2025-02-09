📚 GraphQL Book API
This API allows you to fetch, add, and subscribe to book-related events using GraphQL.

```
🔍 Queries
📖 Get All Books
Retrieve a list of all books:
```

```
query {
  books {
    id
    title
    author
  }
}
```

📘 Get a Book by ID
Fetch a specific book by its ID:

```
query {
  book(id: 1) {
    id
    title
    author
  }
}
```

```
✍️ Mutations
➕ Add a New Book
Use the following mutation to add a new book:
```

```
mutation {
  addBook(title: "The Catcher in the Rye", author: "J.D. Salinger") {
    id
    title
    author
  }
}
```

```
📡 Subscriptions
🔔 Listen for New Book Additions
Subscribe to real-time book additions:
```

```
subscription {
  onBookAdded {
    id
    title
    author
  }
}
```
