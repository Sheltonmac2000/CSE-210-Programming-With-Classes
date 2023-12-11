using System;

Console.WriteLine("Welcome to the All in one Gym Application");
string userInput = "";
string userWorkout = "";

while(true)
{
    Menu menu = new Menu();
    menu.displayMainMenu();
    // Console.WriteLine("Please select an option to begin");
    userInput = Console.ReadLine();

    //Instance of the different classes
    UpperBody upperBody = new UpperBody("This is the","Upper Body Workout", "The focuse will be on strengthennign your chest, back, shoulders and arms.","You did great!");
    CoreWorkout coreWorkout = new CoreWorkout("This is the","Core Body Workout", "The focuse will be on strengtheinig your core; this inclueds your abs and lower back","You did great!");
    LowerBody lowerBody = new LowerBody("This is the","Lower Body Workout", "The focuse will be on strengthening your legs primarily.","You did great!");
    Calesthenics calesthenics = new Calesthenics("This is the","Calesthenics full body workout", "The focuse will be on strengthennign your all major muscles groups of your body without any equipment.","You did great!");
    NutritionTracker nutritionTracker = new NutritionTracker();

    if(userInput == "1")
    {   Console.WriteLine("--- Select one of the workouts below: ---\n");
        menu.displayWorkoutMenu();
        userWorkout = Console.ReadLine();
        

        if(userWorkout == "1")
        {
            Console.WriteLine("\nUpper Body Workout\n");
            upperBody.showRequiredEquipment();
            Console.Write("You may begin your workout in:");
            upperBody.generateCountAnimation();
            upperBody.displayWarmup();
            upperBody.displayIntroduction();
            upperBody.displayWorkout();
            Console.WriteLine("Complete as many of these workouts as you can, then press Enter when you finish your workout. Good luck!");
            Console.ReadLine();
            upperBody.displayEndingMessage();
            Console.WriteLine("You may now begin the cooldown process. Do these workouts to relax your muscles.");
            upperBody.displayCoolDown();
            upperBody.generateLineAnimation();
            Console.WriteLine("\nYou did great today. Now go and get some rest!\n");
        
        }

        else if(userWorkout == "2")
        {
            Console.WriteLine("\nCore Workout\n");
            coreWorkout.showRequiredEquipment();
            Console.Write("You may begin your workout in:");
            coreWorkout.generateCountAnimation();
            coreWorkout.displayWarmup();
            coreWorkout.displayIntroduction();
            coreWorkout.displayWorkout();
            Console.WriteLine("Complete as many of these workouts as you can, then press Enter when you finish your workout. Good luck!");
            Console.ReadLine();
            coreWorkout.displayEndingMessage();
            Console.WriteLine("You may now begin the cooldown process. Do these workouts to relax your muscles.");
            coreWorkout.displayCoolDown();
            coreWorkout.generateLineAnimation();
            Console.WriteLine("\nYou did great today. Now go and get some rest!\n");

        
        }

        else if(userWorkout == "3")
        {
            Console.WriteLine("\n Lower Body Workout\n");
            lowerBody.showRequiredEquipment();
            Console.Write("You may begin your workout in:");
            lowerBody.generateCountAnimation();
            lowerBody.displayWarmup();
            lowerBody.displayIntroduction();
            lowerBody.displayWorkout();
            Console.WriteLine("Complete as many of these workouts as you can, then press Enter when you finish your workout. Good luck!");
            Console.ReadLine();
            lowerBody.displayEndingMessage();
            Console.WriteLine("You may now begin the cooldown process. Do these workouts to relax your muscles.");
            lowerBody.displayCoolDown();
            lowerBody.generateLineAnimation();
            Console.WriteLine("\nYou did great today. Now go and get some rest!\n");
        
        }

        

        else if(userWorkout == "4")
        {
            Console.WriteLine("\n Calesthenics Workout\n");
            calesthenics.showRequiredEquipment();
            Console.Write("You may begin your workout in:");
            calesthenics.generateCountAnimation();
            calesthenics.displayWarmup();
            calesthenics.displayIntroduction();
            calesthenics.displayWorkout();
            Console.WriteLine("Complete as many of these workouts as you can, then press Enter when you finish your workout. Good luck!");
            Console.ReadLine();
            calesthenics.displayEndingMessage();
            Console.WriteLine("You may now begin the cooldown process. Do these workouts to relax your muscles.");
            calesthenics.displayCoolDown();
            calesthenics.generateLineAnimation();
            Console.WriteLine("\nYou did great today. Now go and get some rest!\n");
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
        Console.WriteLine("---BMI Calculator:---");
        BMIcalculator calculator = new BMIcalculator();
        calculator.getWeightAndHeight();
        calculator.getBMI();

    }

    else if(userInput == "3")
    {
        Console.WriteLine("Nutrition Tracker");
        nutritionTracker.trackNutrition();

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
