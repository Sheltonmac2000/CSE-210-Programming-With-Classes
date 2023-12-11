using System.Runtime.CompilerServices;

public class Menu
{
    private List<string> MainMenu = new List<string>{"1. Workouts", "2. BMI Calculator", "3. Nutrition Tracker", "4. Quit"};

    private List<string> WorkoutMenu = new List<string>{"1. Upper Body Workout", "2. Core Workout", "3. Lower Body Workout", "4. Calesthenics", "5. Quit"};


    public void displayMainMenu()
    {
        // Console.WriteLine("--- Select one of the workouts below: ---\n");
        Console.WriteLine("---Please select an option to begin---");
        foreach(string item in MainMenu)
        {   
            Console.WriteLine(item);
        }
    }

    public void displayWorkoutMenu()
    {
        foreach(string item in WorkoutMenu)
        {
            Console.WriteLine(item);
        }
    }
}