using System;

class Program

{

    public static List<Word> instancesList =  new List<Word>();
    public static string input = "";
    static void Main(string[] args)
    {   
       Reference ScriptureRef = new Reference("1 Nephi", 10, 12);
       ScriptureRef.DisplayScripture();

       ScriptureClass splitScripture = new ScriptureClass();
       string[] wordsList = splitScripture.splitWords();

       foreach(string word in wordsList)
       {
        Word instanceWord = new Word(word);
        instancesList.Add(instanceWord);
       }

       
       while(input != "quit")
       {
        Console.Clear();
        foreach(Word i in instancesList)
        {   
            i.DisplayWord();
        }
        // instancesList[10].DisplayWord();
        input = Console.ReadLine();
        instancesList[pickRandomWord()].HideWord();

       }    

    }


    public static int pickRandomWord(){
    Random random = new Random();
    int randomNumber = random.Next(0 , instancesList.Count);
    return randomNumber;

    }
}


