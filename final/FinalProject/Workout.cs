public class Workout
{
    protected string _introMessage;
    protected string _endingMessage;

    protected string _description;

    protected string _nameOfActivity;

    protected bool _isRequired;

    protected List<string> requiredEquipment = new List<string>{
    "\n-----------------------------------",
    "Bench x1", 
    "Dubmbells x2", 
    "barbell x1", 
    "jumnp rope x1",
    "-----------------------------------\n"};

// This is an empty list to be used in the method displayWorkouts(). The subclasses will overwrite it to include each unique list.
// I did this to avoid creating a new method to display the workouts for each subclass.
    protected List<string> Workouts = new List<string>{};


    protected  List<string> Warmups = new List<string>{"1. Jumping Jacks --- 30 seconds", "2. Neck Circles --- 30 seconds", "3. Shoulder Rolls --- 30 seconds.", "4. Lunges --- 30 seconds"};

    protected List<string> Cooldowns = new List<string>{"1. Single leg stance --- 30 seconds.", "2. Neck Stretching --- 30 seconds", "3. Arm Strech --- 30 seconds", "4. Cat-Cow Strech --- 30 seconds", "Butterly Stretch"};

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

    public void showRequiredEquipment()
    {
        if( _isRequired = true)
        {
            Console.WriteLine("This Exercise will require some equpment.");

            Console.WriteLine("You will need the following:");

            foreach(string item in requiredEquipment)
            {
                Console.WriteLine(item);
            }
        }

        else if(_isRequired = false)
        {
            Console.WriteLine("You will not require any equipment for this exercise.");
        }
        
    }

//THis is the generic mehtod that will be overwritten by all the sublcasses. Seee line 14-15 for details.
    public virtual void displayWorkout()
    {
        foreach(string item in Workouts)
        {   Console.WriteLine(item);
        
        }
    }
    

}