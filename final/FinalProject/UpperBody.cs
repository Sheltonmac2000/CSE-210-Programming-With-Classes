public class UpperBody: Workout
{
    bool _isRequired = true;
    private List<string> UpperBodyWorkouts = new List<string>{
        "Chest Workouts:",
        "Dumbell Raises: 4 sets | 12 reps",
        "Bench Press: 4 sets | 10 reps",
        "Inclined Dumbell: 4 sets | 10 reps ",
        "-***********************************-",
        "",
        "Arms Workouts:",
        "Biceps Curls: 4 sets | 12 reps",
        "Incline Curls: 4 sets | 10 reps",
        "Incline Curls: 3 sets | 10 reps",
        "-***********************************-",
        "",
        "Shoulder Workouts:",
        "Lateral raise: 4 sets | 10 reps",
        "Front raise: 4 sets | 10 reps",
        "Arnold Press: 4 sets | 10 reps",
        "Reverse Fly: 4 sets | 10 reps",
        "Jumb Rope",
        "-***********************************-"
        

    };

    public UpperBody (string introMessage, string nameOfActivity, string description, string endingMessage): base(introMessage, nameOfActivity, description, endingMessage)
    {

    }

    // public override void displayWorkouts()
    // {
    //      foreach(string item in UpperBodyWorkouts)
    //     {   Console.WriteLine(item);

    //     }
    // }

    public override void displayWorkout()
    {
        foreach(string item in UpperBodyWorkouts)
        {   Console.WriteLine(item);
        
        }

    }


}