public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _description;
    private string _nameOfActivity;
    // private string _durationPromptString;
    private int _durationPromptInt
    {get; set;}
    

    public Activity( string startingMessage, string nameOfActivity, string description, string endingMessage)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
        _description = description;
        _nameOfActivity = nameOfActivity;
    }

//These are all the getter and setters, that will enable me to change the values of the variables:


    public void displayIntroduction()
    {
        Console.WriteLine($"{_startingMessage} to the {_nameOfActivity} Activity!{_description}");
        
    }

    //this will get the duration from the user, and multimply it by 1000 to get the answer in milliseconds. This will retunr a value that will
    // be used in creating the animations.
    public int getDuration()
    {
         Console.WriteLine("How long would you like to do this activity for(select any number between 0-9)?");
        string _durationPrompt = Console.ReadLine();
        try
        {
            // Use the setter to store the duration
            _durationPromptInt = Convert.ToInt32(_durationPrompt);
           
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the duration.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The entered value is too large to fit into a 32-bit integer.");
        }

        return _durationPromptInt;
    }

    // public virtual void generateAnimation()
    // {int userDuration = _durationPromptInt;

    // for (int i= userDuration; i>0; i-- )
    // {
    //     Console.Write(i);
    //     Thread.Sleep(userDuration*100);
    //     Console.Write($"\b \b");

    // }

    public virtual void generateAnimation()
    {

    for (int cycleDuration= 5; cycleDuration>0; cycleDuration-- )
    {
        Console.Write(cycleDuration);
        Thread.Sleep(1000);
        Console.Write($"\b \b");

    }
    }

//     public virtual void generateAnimation(int _durationPromptInt)
// {
//     for (int seconds = _durationPromptInt; seconds > 0; seconds--)
//     {
//         Console.Write(seconds);
//         Thread.Sleep(1000);
//         Console.Write($"\b \b");
//     }
// }


    public void displayEndingMessage()
    {
        Console.WriteLine($"\n{_endingMessage} :)\n");
        
    }

    public virtual void controlAnimationDuration()
    {
        int userInput = _durationPromptInt;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(userInput);
        // int i = 0;

        while(DateTime.Now < endTime)
        {
            generateAnimation();
        }

    // }
    }

}