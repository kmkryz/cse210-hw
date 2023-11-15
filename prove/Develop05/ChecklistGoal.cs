using System;

namespace GoalTrackingApp
{
    
    public class ChecklistGoal : Goal
    {
        public int _target { get; set; }
        public int _bonusPoints { get; set; }
        public int _completedCount { get;  set; }
        public bool _wasPreviouslyCompleted { get;  set; }

    public ChecklistGoal(string name, int points, bool completed, string description, int target, int bonusPoints, int completedCount, bool wasPreviouslyCompleted) : base(name, points, completed, description)
    {
        this._target = target;
        this._bonusPoints = bonusPoints;
        this._completedCount = completedCount;
        this._wasPreviouslyCompleted = wasPreviouslyCompleted;

    }


    public int CalculateChecklistGoalPoints()
    {
        int totalPoints = 0;

        // Check if the goal is completed
        if (IsCompleted())
        {
            // Check if the goal was not completed in the previous iteration
            if (!_wasPreviouslyCompleted)
            {
                Console.WriteLine($"Congratulations! You've completed the goal: {_name}");
                Console.WriteLine($"You've earned {_bonusPoints} bonus points.");
            }

            // Mark the goal as previously completed
            _wasPreviouslyCompleted = true;
            // Add bonus points once the target is reached
            totalPoints += _bonusPoints;
        }

        // Add points for each event recorded
        totalPoints += _points * _completedCount;

        return totalPoints;
    }


    

        public override void RecordEvent()
        {
            if (!_completed)
            {
                _completedCount++;
                if (_completedCount >= _target)
                {
                    _completed = true;
                }
            }
        }
    }
}