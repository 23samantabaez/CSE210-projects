/* 
base event class for all events
all events need to have an Event Title, Description, Date, Time, and Address

They would like the ability to generate three different messages:

Standard details - Lists the title, description, date, time, and address.
Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.
*/

using System;
using System.Collections.Generic;

class Event
{
    //declare variables
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _eventDate;
    protected string _eventTime;
    protected string _eventAddress;
    protected string _eventType;

    //constructors
    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress )
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public Event(string eventType)
    {
        _eventType = eventType;
    }

    //getters and setters
    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetEventDescription()
    {
        return _eventDescription;
    }

    public string GetEventDate()
    {
        return _eventDate;
    }

    public string GetEventTime()
    {
        return _eventTime;
    }

    public string GetEventAddress()
    {
        return _eventAddress;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    //methods here
    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}, \nDescription: {_eventDescription}\nDate: {_eventDate}\nTime: {_eventTime}\nAddress: {_eventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event type: {_eventType}\nTitle: {_eventTitle}\nDate: {_eventDate} ";
    }

}
