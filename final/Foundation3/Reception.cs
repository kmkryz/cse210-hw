using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception\nEvent: {_title}\nDate: {_date}";
    }
}
