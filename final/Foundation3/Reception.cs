using System;

class Reception : Event
{
    //declare add variables
    private string _emailReservation;
    private string _eventType = "Reception";
    
    //constructors
    public Reception(string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, string _eventAddress, string emailReservation)
        : base(_eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        _emailReservation = emailReservation;
    }

    //getterts and setters
    public string GetEmailReservation()
    {
        return _emailReservation;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: {_eventType}\nRSVP Email: {_emailReservation}";
    }
}