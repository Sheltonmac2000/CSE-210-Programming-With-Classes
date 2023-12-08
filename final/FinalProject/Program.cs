using System;

Console.WriteLine("Welcome to the All in one Gym Application");
string userInput = "";
string userWorkout = "";

while(true)
{
    Menu menu = new Menu();
    menu.displayMainMenu();
    Console.WriteLine("Please select an option to begin");
    userInput = Console.ReadLine();

    //Instance of the UpperBody Class
    UpperBody upperBody = new UpperBody("This is the","Upper Body Workout", "The focuse will be on strengthennign your chest, back, shoulders and arms.","You did great!");
    CoreWorkout coreWorkout = new CoreWorkout("This is the","Core Body Workout", "The focuse will be on strengtheinig your core; this inclueds your abs and lower back","You did great!");
    LowerBody lowerBody = new LowerBody("This is the","Lower Body Workout", "The focuse will be on strengthening your legs primarily.","You did great!");
    Calesthenics calesthenics = new Calesthenics("This is the","Calesthenics full body workout", "The focuse will be on strengthennign your all major muscles groups of your body without any equipment.","You did great!");

    if(userInput == "1")
    {   Console.WriteLine("--- Select one of the workouts below: ---\n");
        menu.displayWorkoutMenu();
        userWorkout = Console.ReadLine();
        

        if(userWorkout == "1")
        {
            Console.WriteLine("\nUpper Body Workout\n");
            upperBody.showRequiredEquipment();
            upperBody.displayIntroduction();
            upperBody.displayWorkout();
            upperBody.displayEndingMessage();
        
        }

        else if(userWorkout == "2")
        {
            Console.WriteLine("\nCore Workout\n");
            coreWorkout.showRequiredEquipment();
            coreWorkout.displayIntroduction();
            coreWorkout.displayWorkout();
            coreWorkout.displayEndingMessage();
        
        }

        else if(userWorkout == "3")
        {
            Console.WriteLine("\n Lower Body Workout\n");
            lowerBody.showRequiredEquipment();
            lowerBody.displayIntroduction();
            lowerBody.displayWorkout();
            lowerBody.displayEndingMessage();
        
        }

        

        else if(userWorkout == "4")
        {
            Console.WriteLine("\n Calesthenics Workout\n");
            calesthenics.showRequiredEquipment();
            calesthenics.displayIntroduction();
            calesthenics.displayWorkout();
            calesthenics.displayEndingMessage();
        
        }

        else if(userWorkout == "5")
        {
            Console.WriteLine("\n Thank you for using the Ultimate Gym Application! \n");
            
        }

        else
        {Console.WriteLine("Please insert the correct input. Choose any number between 1-5.");
        
        }


        
    }

    else if(userInput == "2")
    {
        Console.WriteLine("BMI Calculator:");
        BMIcalculator calculator = new BMIcalculator();
        calculator.getWeightAndHeight();
        calculator.getBMI();

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
