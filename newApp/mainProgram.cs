using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class MainProgram
{   
    public static string userInput;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the journal progam!");
        // Prompts showStuff = new Prompts();
        // showStuff.displayUserEntries();
       
       //THis is the conditional while loop. THe program will continue to run until the user types in 'quit'.
        while (true)
        {
        //This is to show a menu
        Menu displayMenu = new Menu();
        displayMenu.createMenuList();
        Console.Write("What would you like to do?(Select an option between 1 - 5)");
        userInput = Console.ReadLine();
        

        //Here the user will be able to input data, and this should save that data into a text file, so that it can be loaded later.
        if (userInput == "1")
        {
        Console.WriteLine("This is step 1");

        // This will generate random questions for the user to answer.
        Prompts generateRandomQuestion = new Prompts();
        generateRandomQuestion.makeList();

        //This is where the user intput will be saved into a file.
        Prompts createPrompt = new Prompts();
        createPrompt.saveUserResponse();
        
        }

        else if (userInput == "2")
        {
            Console.WriteLine("This is option 2");

            
            Prompts showEntries = new Prompts();
            showEntries.displayUserEntries();
        }

        else if(userInput == "3")
        {
            Console.WriteLine("THis is option 3\n");

            Prompts loadFiles = new Prompts();
            loadFiles.loadUserFile();
        }

        else if(userInput == "4")
        {
            Console.WriteLine("This is to create a custom saved text file. These responses will be different from the the ones that are automatically saved in the user_input.txt file.");
            Console.WriteLine("Provide an answer for the prompt below:\n");

            Prompts generateRandomQuestion = new Prompts();
            generateRandomQuestion.makeList();
            Prompts saveFile = new Prompts();
            saveFile.storeFile();
        }

        else if(userInput == "5")
        {
            Console.WriteLine("Thanks for using the journal app!");
            break;
        }

        else
        {
            Console.WriteLine("Invalid input. Please select an option between 1 - 5 or type 'Quit' to exit. Please remeber that this is case sensitive");
        }
        }

        // Console.WriteLine
                 


        // //THi is to display all the prompts
        // Prompts runProgram = new Prompts();
        // runProgram.makeList();
        // runProgram.saveUserResponse();

        

        }
    }
