using System;

class Running : Activity
{
    //add variables
    private double _runningDistance;

    //constructors
    public Running(DateTime _activityDate, int _activityLength, double runningDistance)
        : base(_activityDate, _activityLength)
    {
        _runningDistance = runningDistance;
    }

    //getters and setters
    public override double GetDistance()
    {
        return _runningDistance;
    }

    public override double GetSpeed()
    {
        return _runningDistance != 0 ? _runningDistance / (_activityLength / 60.0) : 0;
    }

    public override double GetPace()
    {
        return _runningDistance != 0 ? _activityLength / _runningDistance : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({_activityLength} min) - Distance: {_runningDistance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes per mile";
    }
}