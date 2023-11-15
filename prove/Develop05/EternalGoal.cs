using System;

namespace GoalTrackingApp
{
public class EternalGoal : Goal
{
    public int _earnedPoints { get; set; }
    public EternalGoal(string name, int points, bool completed, string description, int earnedPoints) : base(name, points, completed, description)
    {
        this._earnedPoints = earnedPoints;
        _completed = false; 
    }


    public override void RecordEvent()
    {
        // Record the event and receive points each time
        base.RecordEvent();
        // Increment the points when recording an event.
        _earnedPoints += _points;
    }

    public override bool IsCompleted()
    {
        return false; // An eternal goal is never fully completed
    }
}
}
