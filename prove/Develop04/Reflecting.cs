public class Reflecting: Activity
{
    private string randomItem = "";
    private string randomItemQuestion = "";


    //This is the list of  prommpts
    List <string> PromptList = new List<string> {"\n---Think of a time when you stood up for someone else.---", "---Think of a time when you did something really difficult---", "---Think of a time when you helped someone in need.---", "---Think of a time when you did something truly selfless---.\n"};

    //This is the list of questions
    List <string> QuestionList = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?",
     "How can you keep this experience in mind in the future?" };
    public Reflecting(string startingMessage, string endingMessage, string description, string nameOfActivity): base(startingMessage, endingMessage,  description, nameOfActivity)
    {

    }


    
    public string generateRandomPrompt()
    {
        Random randomPrompt = new Random();
        // private string randomItem = "";
        Console.WriteLine("\nConsider the following Prompt:\n");
        int numberOfRandomItems = 1;
        for (int i = 0; i < numberOfRandomItems; i++)
        {
            int randomIndex = randomPrompt.Next(PromptList.Count); //This is where a random index is being generated. The radnom number generato is attached to mu list now.
            randomItem = PromptList[randomIndex];
            Console.WriteLine($"\n{randomItem}\n");

        };

        return randomItem;
    }

    public string generateRandomQuestion()
    {
        Random randomQuestion = new Random();
        // private string randomItem = "";

        int numberOfRandomItems = 2;
        for (int i = 0; i < numberOfRandomItems; i++)
        {
            int randomIndex = randomQuestion.Next(QuestionList.Count); //This is where a random index is being generated. The radnom number generato is attached to mu list now.
            string randomItemQuestion = QuestionList[randomIndex];
            Console.WriteLine($"{randomItemQuestion}\n");
            
            

        };

        return randomItemQuestion;
    }


    public override void generateAnimation()
    {
        List <string> LineAnimations = new List<string>{"|","/","-","\\","|","/","-","\\"};

        // foreach(string i in LineAnimations)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(100);
        //     Console.Write("\b \b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(2);
        int i = 0;

        // Console.Write("Get ready...");

        while(DateTime.Now < endTime)
        {
            string s = LineAnimations[i];
            
            Console.Write(s); 
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;

            if(i >= LineAnimations.Count)
            {
                i = 0;
            }
        }
           
        
        
    //     }

    // }

    // public override void controlAnimationDuration()
    // {
        // Add a feature for it to loop throught the questions until the time ends.
    // }
   


}

}