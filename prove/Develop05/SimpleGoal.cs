using System;

class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
    }

    public SimpleGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {
    }

    public override string Serialize()
    {
        return $"Simple Goal | {_goalName} | {_goalDescription} | {_goalPoints} | | {_goalDone}";
    }

    public override void Deserialize(string serializedGoal)
    {
        base.Deserialize(serializedGoal);
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _goalDone = true;
    }

    public override void PrintGoal()
    {
        base.PrintGoal();
    }
}