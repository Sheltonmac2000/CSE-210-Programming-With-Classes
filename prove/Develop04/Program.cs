using System;

string userInput = null;
// Menu menu = new Menu();
// menu.displayMenu();


// Activity breathing = new Activity("Welcome","Breathing", "...","practice some breathing exercises in sequence.");
// breathing.displayIntroduction();

Console.WriteLine("Welcome to the Program!");

while (true)
{
    Menu menu = new Menu();
    menu.displayMenu();
    Console.Write("Please select on of the options above to begin:");
    userInput = Console.ReadLine();


    if (userInput == "1")
    {
        // userInput = Console.ReadLine();
        
        Console.WriteLine("Breathing Activity");
        Breathing breathing = new Breathing($"Welcome", "Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","You did a great job on this Activity!\n");
        
        //THis introduction method will ask the user for the time.
        breathing.displayIntroduction();
        breathing.getDuration();
        // breathing.BreathInAndOut(_durationPromptInt:);
        breathing.BreathIn(3);
        // breathing.generateAnimation();
        // breathing.controlAnimationDuration();
        breathing.displayEndingMessage();
        
        
    }

    else if (userInput == "2")
    {   
        Console.WriteLine("Reflecting Activity");
        Reflecting reflecting = new Reflecting("Welcome","Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","You did a great job on this Activity!\n");
        
        reflecting.displayIntroduction();
        reflecting.getDuration();
        Console.WriteLine("Get ready...");
        reflecting.generateAnimation();
        reflecting.generateRandomPrompt();
        Console.WriteLine("Take some time to think; press Enter when you are ready.");
        Console.ReadLine(); // this empty readline enables the user to simply press enter, and the programm will proceed.
        reflecting.generateRandomQuestion();
        reflecting.generateAnimation();
        reflecting.controlAnimationDuration();
        reflecting.generateAnimation();
        reflecting.displayEndingMessage();
        

    }

    else if (userInput == "3")
    {
        Console.WriteLine("Listing Activity");
        Listing listing = new Listing("Welcom","Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area",
        "You did a great job on this Activity!\n");

        listing.displayIntroduction();
        listing.getDuration();
        Console.WriteLine("Get ready...");
        listing.generateAnimation();
        listing.showRandomPrompt();
        Console.WriteLine("Take some time to think; press Enter when you are ready.");
        Console.ReadLine();
        Console.Write("You may begin in:");
        listing.generateAnimation();
        listing.EnterMultipleEntries();
        listing.controlAnimationDuration();
        listing.displayEndingMessage();
        // Create methnod to allow user to enter multiple entries.
         
    }

    else if (userInput == "4")
    {
        Console.WriteLine("Thank you for using this application. Have a great day!");
        break;
    }

    else
    {
        Console.WriteLine("Invalid input. Please select an option between 1 - 4 or type '4' to exit.");
    }
}
