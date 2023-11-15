using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTrackingApp
{
    public class GoalMaintenance
    {
        public static void SaveGoals(List<Goal> goals, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    string goalData = $"{goal.GetType().Name}|{goal._name}|{goal._points}|{goal._completed}|{goal._description}";
                    if (goal is EternalGoal eternalGoal)
                    {
                        goalData += $"|{eternalGoal._earnedPoints}";
                    }

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        goalData += $"|{checklistGoal._target}|{checklistGoal._bonusPoints}|{checklistGoal._completedCount}|{checklistGoal._wasPreviouslyCompleted}";
                    }

                    writer.WriteLine(goalData);
                }
            }
        }

        public static List<Goal> LoadGoals(string fileName)
        {
            List<Goal> loadedGoals = new List<Goal>();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string goalData = reader.ReadLine();
                        string[] parts = goalData.Split('|');

                        if (parts.Length < 5)
                        {
                            Console.WriteLine($"Invalid goal data: {goalData}");
                            continue;
                        }

                        string typeName = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        bool completed = bool.Parse(parts[3]);
                        string description = parts[4];

                        if (typeName == nameof(SimpleGoal))
                        {
                            loadedGoals.Add(new SimpleGoal(name, points, completed, description));

                        }
                        else if (typeName == nameof(EternalGoal))
                        {
                            int earnedPoints = int.Parse(parts[5]);
                            loadedGoals.Add(new EternalGoal(name, points, completed, description, earnedPoints ));
                        }
                        else if (typeName == nameof(ChecklistGoal))
                        {
                            if (parts.Length < 8)
                            {
                                Console.WriteLine($"Invalid checklist goal data: {goalData}");
                                continue;
                            }

                            int target = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            int completedCount = int.Parse(parts[7]);
                            bool wasPreviouslyCompleted = bool.Parse(parts[8]);

                            loadedGoals.Add(new ChecklistGoal
                            (name, points, completed, description, target, bonusPoints, completedCount, wasPreviouslyCompleted));
                        }
                    }
                }
            }

            return loadedGoals;
        }
    }
}
