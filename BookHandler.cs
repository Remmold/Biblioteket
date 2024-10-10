using System.Dynamic;

public  class BookHandler
{
    List<Book> AllBooks {get;set;}

    public BookHandler()
    {
        AllBooks = new List<Book>
        {
            new Book("J.R.R Tolkien","Lord of the rings",Genre.Fantasy),
            new Book("Harper Lee", "To Kill a Mockingbird", Genre.Fiction),
            new Book("Patrick Rothfuss", "The Name of the Wind", Genre.Fantasy),
            new Book("Frank Herbert", "Dune", Genre.ScienceFiction),
            new Book("Stieg Larsson", "The Girl with the Dragon Tattoo", Genre.Mystery),
            new Book("Stephen King", "The Shining", Genre.Horror),
            new Book("Jane Austen", "Pride and Prejudice", Genre.Romance),
            new Book("Jack London", "The Call of the Wild", Genre.Adventure),
            new Book("Yuval Noah Harari", "Sapiens: A Brief History of Humankind", Genre.NonFiction),
            new Book("Markus Zusak", "The Book Thief", Genre.Historical),
            new Book("Suzanne Collins", "The Hunger Games", Genre.YoungAdult)
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
            Console.WriteLine($"{b.Title,-20}{b.Author,-20}{b.Genre,-20}");
        }
    }
    public void DisplayBookListInConsole()
    {
        foreach(Book b in AllBooks)
        {
            Console.WriteLine($"{b.Title,-20}{b.Author,-20}{b.Genre,-20}");
        }
    }
}