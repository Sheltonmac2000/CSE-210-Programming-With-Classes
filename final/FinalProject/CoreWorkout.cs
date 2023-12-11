public class CoreWorkout : Workout
{
    // new bool _isRequired = false;
    protected override bool _isRequired{get; set;} = false;

    private List<string> CoreWorkouts = new List<string>{

        "Lower Core Workouts:",
        "Bicycle Crunches: 4 sets | 12 reps",
        "Crunches: 4 sets | 10 reps",
        "Low Plank: 4 sets | 1 minute / set ",
        "-***********************************-",
        "",
        "Mid Core Workouts:",
        "Plank : 4 sets | 1 minute / set",
        "Elevator Lift: 4 sets | 10 reps",
        "Reverse Crunch: 3 sets | 10 reps",
        "-***********************************-",
        "",
        "Upper Core Workouts:",
        "Plank Tap: 4 sets | 1 minute / set",
        "Mountain Climbers: 4 sets | 10 reps",
        "Leg Raises: 4 sets | 10 reps",
        "Lateral Plank Walk: 4 sets | 10 reps",
        "-***********************************-"

    };


    public CoreWorkout (string introMessage, string nameOfActivity, string description, string endingMessage): base(introMessage, nameOfActivity, description, endingMessage)
    {

    }

    public override void displayWorkout()
    {
        foreach(string item in CoreWorkouts)
        {   Console.WriteLine(item);
        
        }

    }

    


    

}