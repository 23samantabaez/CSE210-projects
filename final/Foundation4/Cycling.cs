using System;

class Cycling : Activity
{
    //add variables
    private double _cyclingSpeed;

    //constructors
    public Cycling(DateTime _activityDate, int _activityLength, double cyclingSpeed)
        : base(_activityDate, _activityLength)
    {
        _cyclingSpeed = cyclingSpeed;
    }

    //getters and setters
    public override double GetSpeed()
    {
        return _cyclingSpeed;
    }

    public override double GetDistance()
    {
        return _activityLength != 0 ? _cyclingSpeed * (_activityLength / 60.0) : 0;
    }

    public override double GetPace()
    {
        return _cyclingSpeed != 0 ? 60.0 / _cyclingSpeed : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Stationary Bicycles ({_activityLength} min) - Speed: {_cyclingSpeed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} minutes per mile";
    }
}