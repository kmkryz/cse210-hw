
using System;

namespace GoalTrackingApp
{
    public class Goal
    {
        public string _name { get; set; }
        public int _points { get; set; }
        public bool _completed { get; set; }
        public string _description { get; set; }
        

        public Goal(string name, int points, bool completed, string description)
    {
        this._name = name;
        this._points = points;
        this._completed = completed;
        this._description = description;

    }



        public virtual void RecordEvent()
        {
            if (!_completed)
            {
                _completed = true;
            }
        }



        public virtual bool IsCompleted()
        {
            return _completed;
        }

        public override string ToString()
        {
            return $"{_name} ({_points} points) - {_description}";
        }
    }









}

    
