using System;

class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0; // To be overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // To be overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // To be overridden in derived classes
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{_date} - {GetType().Name} - ({_duration} min):";
        summary += $" Distance: {distance:F2} miles, Speed: {speed:F2} mph, Pace: {pace:F2} min per mile";

        return summary;
    }
}
