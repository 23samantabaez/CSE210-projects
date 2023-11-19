using System;

class ChecklistGoal : Goal
{

    private int _bonusPoints = 0;
    private int _targetEvents = 0;


    public ChecklistGoal() : base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _targetEvents = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int targetEvents, int bonusPoints) : base (goalName, goalDescription, goalPoints) 
    {
        _targetEvents = targetEvents;
        _bonusPoints = bonusPoints;
    }

    public override string Serialize()
    {
        return$"Checklist Goal | {_goalName} | {_goalDescription} | {_goalPoints} | {_eventCount} | {_goalDone} | {_targetEvents} | {_bonusPoints}";
    }

    public override void Deserialize(string serializedGoal)
    {
        string[] parts = serializedGoal.Split("|");
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _eventCount = int.Parse(parts[4]);
        _goalDone = Boolean.Parse(parts[5]);
        _targetEvents = int.Parse(parts[6]);
        _bonusPoints = int.Parse(parts[7]);
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        if (_eventCount >= _targetEvents)
        {
            _goalDone = true;
        }
    }

    public override void PrintGoal()
    {
        string statusString = "";
        if (_goalDone)
        {
            statusString = "x";
        }

        Console.Write($"[{statusString} {_goalName}: ({_goalDescription}) - currently completed: {_eventCount}/{_targetEvents}]");
    }
}
