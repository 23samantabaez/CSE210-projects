using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints = 0;
    protected int _eventCount = 0;
    protected Boolean _goalDone = false;

    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine(); //store description in variable? 

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public Goal(string goalName, string goalDescription, int goalPoints) //constructor with parameter
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public virtual string Serialize()
    {
        return$"Goal | {_goalName} | {_goalDescription} | {_goalPoints} | {_goalDone}";
    }

    // indexes in list for id
    public virtual void Deserialize(string serializedGoal)
    {
        string[] parts = serializedGoal.Split("|");
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _eventCount = int.Parse(parts[4]);
        _goalDone = Boolean.Parse(parts[5]);
    }

    public virtual void RecordEvent()
    {
        _eventCount += 1;
    }

    public virtual void PrintGoal()
    {
        string statusString = " ";
        string countDetail = "";

        if (_goalDone)
        {
            statusString = "x";
        }

        if (_eventCount > 0)
        {
            countDetail = $" - done {_eventCount} times. ";
        }

        Console.Write($"[{statusString} {_goalName} ({_goalDescription}) {countDetail}]"); //add countDetail?
    }
}