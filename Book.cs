public class Book
{
    public string Title {get;set;}
    public string Author {get;set;}
    
    public Genre Genre {get;set;}

    public Book(string title,string author,Genre genre)
    {
        Title = title;
        Author = author;
        Genre = genre;
    }
}