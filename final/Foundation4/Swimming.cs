using System;


class Swimming : Activity
{
    private int _laps { get; }

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60 ; // Speed in mph
    }

    public override double GetPace()
    {
        double speed = GetSpeed();

        // Avoid division by zero
        if (speed == 0)
        {
            return double.PositiveInfinity;
        }

        return 60 / speed; 
    }
}

