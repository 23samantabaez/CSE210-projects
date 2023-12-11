

class OutdoorGathering : Event
{
    //declare add variables
    private string _weatherStatement;
    private string _eventType = "Outdoor Gathering";
    
    //constructors
    public OutdoorGathering(string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, string _eventAddress, string weatherStatement)
        : base(_eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        _weatherStatement = weatherStatement;
    }

    //getterts and setters
    public string GetWeatherStatement()
    {
        return _weatherStatement;
    }

    //overriden method
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: {_eventType}\nWeather Statement: {_weatherStatement}";
    } 
}