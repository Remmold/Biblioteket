using System.Net.Http.Headers;

public static class Util
{

    public static int ValidateInteger(string stringToParse)
    {
        while(true)

        {
            if(int.TryParse(stringToParse,out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Endast Heltal Tack");
                stringToParse = Console.ReadLine();
            }
        }
    }
    public static string ValidateString(string stringToValidate)
    {
        while(true)
        {

        
            if(stringToValidate == "")
            {
                Console.WriteLine("Du måste mata in någonting");
                stringToValidate = Console.ReadLine();
            }
            else return stringToValidate;
        }
    }
}