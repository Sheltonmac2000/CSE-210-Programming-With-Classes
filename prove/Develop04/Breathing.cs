public class Breathing : Activity
{
    //When a subclass inherits a constructor from the parent class, you must create construcotr for the child class and and the ke
    public Breathing(string startingMessage, string nameOfActivity, string description, string endingMessage): base(startingMessage, nameOfActivity,  description, endingMessage)
    {

    }

//     public void BreathInAndOut(int _durationPromptInt)
// {
//     int cycleDuration = 5; // Initial cycle duration
//     int numberOfCycles = _durationPromptInt / cycleDuration;

//     for (int cycle = 0; cycle < numberOfCycles; cycle++)
//     {
//         Console.WriteLine("You can breathe in now..."); 
//         generateAnimation(cycleDuration);
//         Console.WriteLine("Breathe out..."); 
//         generateAnimation(cycleDuration);
//     }
// }

    public void BreathIn(int numberOfCycles)
   {
        for (int cycle = 0; cycle < numberOfCycles; cycle++)
        {
                Console.WriteLine("You can breathe in now..."); // Attach a timer animation here
                generateAnimation();
                Console.WriteLine("Breathe out..."); // Attach a timer animation here
                generateAnimation();
        }
   }

//     public override void controlAnimationDuration()
//     {
        //Add a feature to loop through the breathe function until the timer ends.
//     }
}