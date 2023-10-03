public class Entry {

    public DateTime _date;
    public string  _prompt;
    public string _response;
    public string _mood;




        public static Entry GetEntry(string _prompt){

            Console.Write("Your Response: ");
            string _userResponse = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your overall mood today? ");
            string _userMood = Console.ReadLine();
            Console.WriteLine();

            Entry _entry = new Entry{
                _date = DateTime.Now,
                _prompt = _prompt,
                _response = _userResponse,
                _mood = _userMood
                //TO EXCEED REQUIREMENTS I ADDED ANOTHER ENTRY TO THE USER
                //JOURNAL ENTRY, THEIR OVERALL MOOD FOR THE DAY
            };


            Console.WriteLine($"Date: {_entry._date} Prompt: {_prompt} Entry: {_entry._response} Mood: {_entry._mood}");

            return _entry;
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