using System;

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception\nTitle: {title}\nDate: {date}";
    }
}
