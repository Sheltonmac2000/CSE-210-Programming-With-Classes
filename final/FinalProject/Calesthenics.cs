public class Calesthenics : Workout
{
    bool _isRequired = false;

    private List<string> CalesthenicsWorkouts = new List<string>{

        "Upper Strenght Workouts:",
        "Push-ups: 4 sets | 12 reps",
        "Pull-ups: 4 sets | 10 reps",
        "jumping pushups: 4 sets | 10 reps ",
        "-***********************************-",
        "",
        "Core Strength Workouts:",
        "Planks: 4 sets | 1-2 minutes/set ",
        "Hollow BOdy Crunch: 4 sets | 10 reps",
        "Dragon Flags: 3 sets | 30-45 seconds / set",
        "-***********************************-",
        "",
        "Leg Strengh Workouts:",
        "Squats: 4 sets | 10 reps | Use x1 dumbell",
        "Glute Bridges: 4 sets | 10 reps | Use x1 barbell",
        "Lunges: 4 sets | 10 reps",
        "Calf Raise: 4 sets | 10 reps",
        "-***********************************-"
    };

    public Calesthenics (string introMessage, string nameOfActivity, string description, string endingMessage): base(introMessage, nameOfActivity, description, endingMessage)
    {

    }

    public override void displayWorkout()
    {
        foreach(string item in CalesthenicsWorkouts)
        {   Console.WriteLine(item);
        
        }

    }



}