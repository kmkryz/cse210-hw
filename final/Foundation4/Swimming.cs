using System;

class Swimming : Activity
{
    public int Laps { get; }

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60 * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return 60 / (GetSpeed() / 60); // Pace in minutes per kilometer
    }
}
