using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Type: Lecture\nEvent: {_title}\nDate: {_date}";
    }
}
