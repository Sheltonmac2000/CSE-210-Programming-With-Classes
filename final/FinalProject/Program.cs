using System;

Console.WriteLine("Welcome to the All in one Gym Application");
string userInput = "";

while(true)
{
    Menu menu = new Menu();
    menu.displayMainMenu();
    Console.WriteLine("Please select an option to begin");
    userInput = Console.ReadLine();

    if(userInput == "1")
    {   Console.WriteLine("--- Select one of the workouts below: ---");
        menu.displayWorkoutMenu();
        Console.ReadLine();
    }

    else if(userInput == "2")
    {
        Console.WriteLine("BMI Calculator");
    }

    else if(userInput == "3")
    {
        Console.WriteLine("Nutrition Tracker");
    }

    else if(userInput == "4")

    {
        Console.WriteLine("Thank you for using this app!");
        break;
    }

    else
    {
        Console.WriteLine("Invalid Input. Please select an option from the menu.");
    }
}
