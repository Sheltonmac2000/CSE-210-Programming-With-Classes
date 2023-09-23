using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage was your grade?");
        string userInput = Console.ReadLine();
        int inputInteger = Convert.ToInt32(userInput);
        Console.WriteLine($"This is the number that you printed out: {inputInteger}");

        while (inputInteger != 0)
            if (inputInteger >= 90)
            {
                Console.WriteLine($"Congratulations, you got A.");
            }
            else if (inputInteger >= 80)
            {
                Console.WriteLine($"Congratulations, you got a B.");
            }
            else if (inputInteger >= 70)
            {
                Console.WriteLine($"Congratulations, you got a C.");
            }
            else if (inputInteger >= 60)
            {
                Console.WriteLine($"Congratulations, you got a D.");
            }
            else if (inputInteger < 60)
            {
                Console.WriteLine($"You got an F. You can surely do better.");
            }
        else 
            { Console.WriteLine("You quit the program.") };
        
    }
}




