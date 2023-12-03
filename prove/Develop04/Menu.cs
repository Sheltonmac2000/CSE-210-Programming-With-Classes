using System.Runtime.CompilerServices;

public class Menu
{
    List<string> menuList = new List<string> 
    {"1. Start Breathing Activity", "2. Start Reflecting Activity","3. Start listing Activity","4. Quit"};

    public List<string> displayMenu()
    {
        foreach(string choice in menuList)
        {
            Console.WriteLine(choice);
        }

        return menuList;
    }
}