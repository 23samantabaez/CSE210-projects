class Lecture : Event
{
    //declare additional variables
    private string _speakerName;
    private string _capacity;


    //constructors
    //public Lecture(string speakerName, string capacity)
    public Lecture(string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, string _eventAddress, string speakerName, string capacity) 
        : base(_eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    private string _eventType = "Lecture";

    //getters and setters
    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public string GetCapacity()
    {
        return _capacity;
    }

    //methods
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: {_eventType}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}
