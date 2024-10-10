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
    public static string ValidateString()
    {
        while(true)
        {
            string stringToValidate = Console.ReadLine();
        
            if(stringToValidate == "")
            {
                Console.WriteLine("Du måste mata in någonting");
                stringToValidate = Console.ReadLine();
            }
            else return stringToValidate;
        }
    }


    public static void DisplayMenu(List<String> optionsList,List<Action> methodList)
    {
        bool isRunning = true;
        int markedIndex = 0;
        for(int i = 0; i< optionsList.Count;i++)
        {
            
            
            while(isRunning)
            {
                Console.Clear();
                if(i == markedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"[{i+1}{optionsList[i]}]");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"[{i+1}{optionsList[i]}]");
                }
            
            
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if(markedIndex > 0)
                        {
                            markedIndex--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if(markedIndex < optionsList.Count-1)
                        {
                            markedIndex++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        methodList[i]();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.Backspace:
                        isRunning = false;
                        break;  
                }
            }
        }        
    }
}