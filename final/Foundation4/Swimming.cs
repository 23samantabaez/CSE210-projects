using System;

class Swimming : Activity
{
    //add variables
    private int _numberLaps;

    //constructors
    public Swimming(DateTime _activityDate, int _activityLength, int numberLaps)
        : base(_activityDate, _activityLength)
    {
        _numberLaps = numberLaps;
    }

    //getters and setters
    public int GetSwimmingLaps()
    {
        return _numberLaps;
    }

    public override double GetDistance()
    {
        return _numberLaps * 50.0 / 1000 * 0.62; // In miles
    }

    public override double GetSpeed()
    {
        return GetDistance() != 0 ? GetDistance() / (_activityLength / 60.0) : 0;
    }

    public override double GetPace()
    {
        return GetDistance() != 0 ? _activityLength / GetDistance() : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({_activityLength} min) - Laps: {_numberLaps}, Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes per mile";
    }

}