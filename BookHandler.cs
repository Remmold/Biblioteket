using System.Dynamic;

public  class BookHandler
{
    List<Book> AllBooks {get;set;}

    public BookHandler()
    {
        AllBooks = new List<Book>
        {
            new Book("Lord of the Rings", "J.R.R Tolkien", Genre.Fantasy),
            new Book("To Kill a Mockingbird", "Harper Lee", Genre.Fiction),
            new Book("The Name of the Wind", "Patrick Rothfuss", Genre.Fantasy),
            new Book("Dune", "Frank Herbert", Genre.ScienceFiction),
            new Book("The Girl with the Dragon Tattoo", "Stieg Larsson", Genre.Mystery),
            new Book("The Shining", "Stephen King", Genre.Horror),
            new Book("Pride and Prejudice", "Jane Austen", Genre.Romance),
            new Book("The Call of the Wild", "Jack London", Genre.Adventure),
            new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", Genre.NonFiction),
            new Book("The Book Thief", "Markus Zusak", Genre.Historical),
            new Book("The Hunger Games", "Suzanne Collins", Genre.YoungAdult)

        };
    }
    /// <summary>
    /// Removes a book from a list of books
    /// </summary>
    /// <param name="books"></param>
    /// <param name="bookToRemove"></param>
    public void RemoveBookFromList(List<Book> books,Book bookToRemove)
    {
        books.Remove(bookToRemove);
    }
    /// <summary>
    /// Removes a book from All Book list
    /// </summary>
    /// <param name="bookToRemove"></param>
    public void RemoveBookFromList(Book bookToRemove)
    {
        AllBooks.Remove(bookToRemove);
    }

    public void AddBookToList(List<Book> books,Book bookToAdd)
    {
        books.Add(bookToAdd);
    }
    public void AddBookToList(Book bookToAdd)
    {
        AllBooks.Add(bookToAdd);
    }
    public void DisplayBookListInConsole(List<Book> books)
    {
        foreach(Book b in books)
        {
            Console.WriteLine($"{b.Title,-45}{b.Author,-45}{b.Genre,-20}");
        }
    }
    public void DisplayBookListInConsole()
    {
        DisplayBookListInConsole(AllBooks);
    }
}