// This is the Prompts class
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
public class Prompts
 {
    public string _prompt1 = "How am I feeling today?";
    public string _prompt2 = "What have I been thinking abou the most today?";
    public string _prompt3 = "Where did I find peace today?";
    public string _prompt4 = "Did I take the time to ponder today?";
    public string _prompt5 = "What should I do better for tomorrow?";

    // THis is a method/function that will create a new List:
    public string generateRandom()
    {   
        //THis will creat a new empty list:
        List<string> promptList = new List<string>();

        //THis will add new variables to the list.
        promptList.Add(_prompt1);
        promptList.Add(_prompt2);
        promptList.Add(_prompt3);
        promptList.Add(_prompt4);
        promptList.Add(_prompt5);

        //This creates a random number generator
        Random randomPrompt = new Random();
        string randomItem = "";

        //This will specify how many random items to print. This will be used to generate a random index to print from my List.
        //It will be attached to my list.
        int numberOfRandomItems = 1; //THis will only print one item from the list at a time. You can change it anytime.

        for (int i = 0; i < numberOfRandomItems; i++)
        {
            int randomIndex = randomPrompt.Next(promptList.Count); //This is where a random index is being generated. The radnom number generato is attached to mu list now.
            randomItem = promptList[randomIndex];
            Console.WriteLine(randomItem);

        };

        return randomItem;
    }

    //THis class will ask the user random questions, then it will save the responses.
    // public void saveUserResponse()
    // {
    //     Console.WriteLine("Type in your answer below:");
    //     string userResponse = Console.ReadLine();
    //     Console.WriteLine($"This is what you typed in: {userResponse}"); 

    //     //This will prompt the use to the name the .txt file that they want to save to.
    //     // Console.WriteLine("Enter a filename to save your responses:");
    //     // string fileName = Console.ReadLine();

    //     // if(string.IsNullOrWhiteSpace(fileName))
    //     // {
    //     //     Console.WriteLine("This is an invalid filename. Please do not add any spaces. Try again.");
    //     //     return;
    //     // }

    //     //This will creat a new list to store all the user inputs.    
    //     using(StreamWriter writer = File.AppendText("/Users/sheltonmacamo/Desktop/CSE 210 CLASS FOLDER/newApp/user_input.txt"))
    //     {
    //         DateTime currentDate = DateTime.Now;
    //         string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss \n");
    //         writer.WriteLine($"{formattedDate}: {userResponse}");
    //         // writer.WriteLine(formattedDate);
    //     }
       
    //    Console.WriteLine("Your response has been saved.");
    //  }

    // public void storeFile()
    // {
    //     Console.WriteLine("Type in your answer below:");
    //     string userResponse = Console.ReadLine();
    //     Console.WriteLine($"This is what you typed in: {userResponse}"); 

    //     //This will prompt the use to name the .txt file that they want to save to.
    //     Console.WriteLine("Enter a filename to save your responses:");
    //     string fileName = Console.ReadLine();

    //     if(string.IsNullOrWhiteSpace(fileName))
    //     {
    //         Console.WriteLine("This is an invalid filename. Please do not add any spaces. Try again.");
    //         return;
    //     }

    //     //This will creat a new list to store all the user inputs.    
    //     // using(StreamWriter writer = File.AppendText($"{fileName}"))
    //     // {
    //     //     DateTime currentDate = DateTime.Now;
    //     //     string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss \n");
    //     //     writer.WriteLine($"{formattedDate}: {userResponse}");
    //     //     // writer.WriteLine(formattedDate);
    //     // }
       
    //    Console.WriteLine($"Your response has been saved to {fileName}");
    // }
    // public void displayUserEntries()
    // {   

        
    //     //This will check if the file exists in the current directory.
    //     if(File.Exists("/Users/sheltonmacamo/Desktop/CSE 210 CLASS FOLDER/newApp/user_input.txt"))
    //     {   
    //         //This will read the file
    //         string[] lines = File.ReadAllLines("/Users/sheltonmacamo/Desktop/CSE 210 CLASS FOLDER/newApp/user_input.txt");  

    //         foreach(string line in lines)
    //         {
    //             Console.WriteLine(line);
    //             string[] parts = line.Split(":");

    //             if(parts.Length >=2)
    //             {
    //                 string date = parts[0].Trim();
    //                 string input = parts[1].Trim();

    //                 Console.WriteLine($"{date}: {input}");

    //             }
    //             else
    //             {
    //                 Console.WriteLine("Invalid line format:" + line);
    //             }
    //         }
  
    //     }

    //     else
    //     {
    //         Console.WriteLine("No user inputs found.");
    //     }  
    // }
    
    // public void loadUserFile()
    // {

    //     //THis will prompt the user to enter the name of the file that they want to load:
    //     Console.WriteLine("Enter the name of the file that you want to load.");
    //     string fileName = Console.ReadLine();

    //     if(string.IsNullOrWhiteSpace(fileName))
    //     {
    //         Console.WriteLine("THis is an invalid filename. Please provide a valid filename.");
    //         return;
    //     }

    //     //THis will combine the name of the file that the user chooses, to the path in this directory.
    //     string filePath = Path.Combine("/Users/sheltonmacamo/Desktop/CSE 210 CLASS FOLDER/newApp", fileName + ".txt");

    //     if(File.Exists(filePath))
    //     {   
    //         //This will read the file
    //         string[] lines = File.ReadAllLines(filePath);  

    //         foreach(string line in lines)
    //         {
    //             Console.WriteLine(line);
    //             string[] parts = line.Split(":");

    //             if(parts.Length >=2)
    //             {
    //                 string date = parts[0].Trim();
    //                 string input = parts[1].Trim();

    //                 Console.WriteLine($"{date}: {input}");

    //             }
        //         else
        //         {
        //             Console.WriteLine("Invalid line format:" + line);
        //         }
        //     }
  
        // }

    //     else
    //     {
    //         Console.WriteLine("No such file could be found. Please provide an existing filename.");
    //     }  
    // }

}

