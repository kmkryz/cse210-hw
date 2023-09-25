public class Entry {

    public DateTime _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} Entry: {_response} Mood: {_mood}");
    }
}

// +-----------------------------------+
// |               Entry               |
// +-----------------------------------+
// | _date: DateTime                   |
// | _prompt: string                   |
// | _response: string                 |
// +-----------------------------------+
// | DisplayEntry(_date: DateTime,     |
// |         _prompt: string,          |
// |         _response: string)        |
// +-----------------------------------+