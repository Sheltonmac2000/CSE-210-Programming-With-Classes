public class LowerBody : Workout
{
    bool _isRequired = true;

    private List<string> LowerBodyWorkouts = new List<string>{

        "Quad Workouts:",
        "Lunges: 4 sets | 12 reps",
        "Bulgarian Split Squat: 4 sets | 10 reps",
        "Front Squats: 4 sets | 10 reps ",
        "-***********************************-",
        "",
        "Calves Workouts:",
        "Leg Press Calf Raises: 4 sets | 12 reps | Use x1 barbell",
        "Single Leg Calf Raise: 4 sets | 10 reps",
        "Jumping Jacks: 3 sets | 2 minutes / set",
        "-***********************************-",
        "",
        "Hamstring Workouts:",
        "Dumbell Swing: 4 sets | 10 reps | Use x1 dumbell",
        "Deadlift: 4 sets | 10 reps | Use x1 barbell",
        "Glut Ham Raise: 4 sets | 10 reps",
        "Reverse Fly: 4 sets | 10 reps",
        "-***********************************-"
    };
    public LowerBody (string introMessage, string nameOfActivity, string description, string endingMessage): base(introMessage, nameOfActivity, description, endingMessage)
    {

    }


     public override void displayWorkout()
    {
        foreach(string item in LowerBodyWorkouts)
        {   Console.WriteLine(item);
        
        }

    }
}