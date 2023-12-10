using System;


class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string StandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\nType: ";
    }

    public virtual string ShortDescription()
    {
        return $"Type: Generic Event\nTitle: {_title}\nDate: {_date}";
    }
}
