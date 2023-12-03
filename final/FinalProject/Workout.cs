public class Workout
{
    private string _introMessage;
    private string _endingMessage;

    private string _description;

    private string _nameOfActivity;


    private  List<string> Warmups = new List<string>{"1. Jumping Jacks --- 30 seconds", "2. Neck Circles --- 30 seconds", "3. Shoulder Rolls --- 30 seconds.", "4. Lunges --- 30 seconds"};

    private List<string> Cooldowns = new List<string>{"1. Single leg stance --- 30 seconds.", "2. Neck Stretching --- 30 seconds", "3. Arm Strech --- 30 seconds", "4. Cat-Cow Strech --- 30 seconds", "Butterly Stretch"};

    public Workout(string introMessage, string nameOfActivity, string description, string endingMessage)
    {
        _introMessage = introMessage;
        _nameOfActivity = nameOfActivity;
        _description = description;
        _endingMessage = endingMessage;
    }

    public void displayIntroduction()
    {
        Console.WriteLine($"{_introMessage} to the {_nameOfActivity} Activity!{_description}");
    }

     public void displayEndingMessage()
    {
        Console.WriteLine($"\n{_endingMessage} :)\n");
        
    }

}