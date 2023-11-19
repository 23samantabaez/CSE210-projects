using System;

class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
    }

    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {
    }

    public override string Serialize()
    {
        return $"Eternal Goal | {_goalName} | {_goalDescription} | {_goalPoints} | | {_goalDone}";
    }

    public override void Deserialize(string serializedGoal)
    {
        base.Deserialize(serializedGoal);
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override void PrintGoal()
    {
        base.PrintGoal();
    }
}