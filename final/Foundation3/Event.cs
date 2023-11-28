using System;


class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string StandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\nType: Generic Event";
    }

    public virtual string ShortDescription()
    {
        return $"Type: Generic Event\nTitle: {title}\nDate: {date}";
    }
}
