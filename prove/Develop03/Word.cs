public class Word
{
    public string _word;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        if(_isHidden == true)
        {
            Console.Write("---  ");
        }
        else
        {
            Console.Write(_word + " ");
        }
        
    }

    public void HideWord()
    {
        _isHidden = true;
    }
}