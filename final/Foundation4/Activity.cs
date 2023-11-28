using System;

class Activity
{
    public string Date { get; }
    public int Duration { get; }

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
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

        string summary = $"{Date} {GetType().Name} ({Duration} min):";
        summary += $" Distance: {distance:F2} miles, Speed: {speed:F2} mph, Pace: {pace:F2} min per mile";

        return summary;
    }
}
