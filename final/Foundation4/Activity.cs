using System;
//For each activity, they want to track the the date and the length 
//of the activity in minutes. 
//need: real datetime


class Activity
{
    //declare variables
    private DateTime _activityDate;
    protected int _activityLength;


    //constructors
    public Activity(DateTime activityDate, int activityLength)
    {
        _activityDate = activityDate;
        _activityLength = activityLength;
    }


    //getters and setters
    public string GetActivityDate()
    {
        return _activityDate.ToShortDateString();
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }


    //override and virtual methods for distance, speed, pace.
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{_activityDate.ToShortDateString()}";
    }
}