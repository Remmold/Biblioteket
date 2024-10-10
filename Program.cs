public class Program
{
    public static BookHandler bookHandler = new BookHandler();
    public static void Main()
    {
    
        Console.WriteLine("Välkommen till Bibliotekets inloggning");
        Console.WriteLine("Logga in som ");
        Console.WriteLine("[1]Användare");
        Console.WriteLine("[2]Administratör");
        string input = Util.ValidateString();
        switch(input)
        {
            case "1":
                break;
            case "2":
                bookHandler.DisplayMenuAdmin();
                break;
        }
        
    }
}