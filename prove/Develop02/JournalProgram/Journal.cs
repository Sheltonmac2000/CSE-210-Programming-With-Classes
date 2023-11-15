using System;
using System.IO;
using System.Collections.Generic;



public class Journal
{   //This is a list that will store all the entries(includes promt, response and time)
    private List<Entries> EntriesList = new List<Entries>();

    //This method will save the entries into a list
    public void SaveEntriesIntoList(Entries newEntry)
    {
            EntriesList.Add(newEntry);
    }

    // public void ShowEntries(Entries newEntry)
    // {   
    //     // EntriesList.Add(newEntry);
    //     // foreach(Entries entry in EntriesList)
    //     // Console.WriteLine(entry);
        

       
    // }
    public void ShowEntries()
{
    if (EntriesList.Count > 0)
    {
        Console.WriteLine("All Entries:");
        foreach (Entries entry in EntriesList)
        {
            Console.WriteLine(entry);
        }
    }
    else
    {
        Console.WriteLine("No entries in the journal yet.");
    }
        }
    public void SaveFile()
    {   
        Console.WriteLine("What would you like to name your file?");
        string filename = Console.ReadLine();
        string ActualFile = $"{filename}.txt";
        using (StreamWriter outputFile = new StreamWriter(ActualFile))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entries entry in EntriesList)
            {
                outputFile.WriteLine(entry.ToString());
                
            }
            Console.WriteLine($"Your file has been saved as {filename}");
            
        }
    }

    public static  List<Entries> LoadFile()
    {
        List<Entries> SavedEntries = new List<Entries>();
        Console.WriteLine("Reading List from your file.");
        Console.WriteLine("Please indicate the name of the file that you would like to open:");
        string userInput = Console.ReadLine();
        string userFile = $"{userInput}.txt";
        string[] Savedfile = System.IO.File.ReadAllLines(userFile);

        foreach(string line in Savedfile )
        {
            Console.WriteLine(line);
        }
        return SavedEntries;
    }
}