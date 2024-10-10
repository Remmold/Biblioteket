public class Program
{
    public static BookHandler bookHandler = new BookHandler();
    public static void Main()
    {
    
    bookHandler.DisplayBookListInConsole();
    Console.ReadKey();


    }
}