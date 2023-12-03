using System;
using System.Collections.Generic;

public class Listing :Activity
{
    public Listing(string startingMessage, string endingMessage, string description, string nameOfActivity): base(startingMessage, endingMessage,  description, nameOfActivity)
    {

    }

    private string randomItem = "";

    List<string> PromptList = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    public string showRandomPrompt()
    {
         
        Random randomPromptListing = new Random();
        // private string randomItem = "";
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");

        int randomItemsListing = 1;
        for (int i = 0; i < randomItemsListing; i++)
        {
            int randomIndex = randomPromptListing.Next(PromptList.Count); //This is where a random index is being generated. The radnom number generato is attached to mu list now.
            randomItem = PromptList[randomIndex];
            Console.WriteLine($"---{randomItem}---\n");

        };

        return randomItem;
    }

    private List<string> userEntries = new List<string>();
    // private string userInput = Console.ReadLine();
    public  void EnterMultipleEntries()
    {
        Console.WriteLine("Enter your items here, and press enter to continue adding more items.");

        while(true)
        {
            string userInput = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(userInput))
            {
                break;
            }

            else if(userInput.ToLower()== "exit")
            {
                break;
            }

            userEntries.Add(userInput);
        }

        // Console.WriteLine($"Total entered Items:{userEntries.Count()}");

        foreach(string entry in userEntries)
        {   Console.WriteLine("This is what you entered:");
            Console.WriteLine(entry);
            
        }

        Console.WriteLine($"Total entered Items:{userEntries.Count()}");
        
    }
    

}
