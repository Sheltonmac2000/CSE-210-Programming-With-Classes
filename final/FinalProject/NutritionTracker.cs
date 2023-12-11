using System;
using System.Collections.Generic;

public class NutritionTracker
{
    private string promptMeal;

    private int promptCalories;

    private static List<Tuple<string, int>> mealEntries = new List<Tuple<string, int>>();

    // public static List
    public void trackNutrition()
    {
        while(true)
        {
            Console.WriteLine("Enter the meal that you had today. Type in 'exit' to finish:");
            string promptMeal = Console.ReadLine().ToLower();

            if(promptMeal == "exit")
            {
                break;
            }

            Console.WriteLine("Enter the number of calories: ");
            if(int.TryParse(Console.ReadLine(), out int promptCalories))
            {
                mealEntries.Add(new Tuple<string, int>(promptMeal, promptCalories));
                Console.WriteLine("Your entries have been recorded.");

            }

            else
            {
                Console.WriteLine("Invalid inpout for calories. Please enter a valid number.");
            }

            Console.WriteLine("Your Nutrition Entries:");
            foreach(var entry in mealEntries)
            {
                Console.WriteLine($"{entry.Item1}: {entry.Item2}");
            }
        }
    }
}