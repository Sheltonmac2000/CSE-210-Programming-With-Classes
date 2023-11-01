// using System.Text;

// public class Scripture
// {
//     public string _reference;
//     public string _chapter;
//     public string _verse;
//     public string _scripture;

//     //THis constructor builds the scripture to dipslay .
//     public Scripture(string reference, string chapter, string verse, string scripture)
//     {
//         _reference = reference;
//         _chapter = chapter;
//         _verse = verse;
//         //This scripture needs to be converted into a list, where we split each word and store it in a list. That way we can remove each word in the list.
//         _scripture = scripture;
//         string[] sentences = _scripture.Split(".");

//         //Split each sentence into words
//         List<string> seperateWords = new List<string>();


//         //This will generate random indices 
//         Random random = new Random();

//         int wordsToReplaceCount = 2;

//         for (int i = 0; i <wordsToReplaceCount; i++)
//         {
//             int randomIndex = random.Next(seperateWords.Count);
//             sentences[randomIndex] = "--";
//         }

//         foreach(string word in seperateWords)
//         {
//             Console.WriteLine(word);
//         }



//     }

//     public void DisplayScripture()
//     {
//         Console.WriteLine($"{_reference} {_chapter}: {_verse} \n{_scripture}");
//     }



// }


using Microsoft.VisualBasic;

public class ScriptureClass
{
string _scriptureText ="For behold, it came to pass after my father had made an end of speaking the words of his adream, and also of exhorting them to all diligence, he spake unto them concerning the Jews ";
string[] wordList;

List<Word> instanceList = new List<Word>();

//THis will split the scripture and store it in the wordlist
public string[] splitWords()
{   //This splits the word by spaces
    string[] wordList = _scriptureText.Split(" ");
    //This loop will create a new instance each time and store it in a new list.
   return wordList;
}



}