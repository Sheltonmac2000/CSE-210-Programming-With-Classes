public class Entries
{//This class will hold the user prompt, the response, and the date.
    private string _randomPrompt;
    private string _userResponse;
    private string _dateEntered;

    public Entries(string randomPrompt, string userResponse)
    {
        _randomPrompt = randomPrompt;
        _userResponse = userResponse;
        _dateEntered = DateTime.Now.ToString("dd MMMM yyyy");
    }

    public override string ToString()
    {
        return $"{_randomPrompt}~{_userResponse}~{_dateEntered}";
    }

    // public string DisplayAsString()
    // {
    //     return $"{_randomPrompt}~{_userResponse}~{_dateEntered}";
    // }

}