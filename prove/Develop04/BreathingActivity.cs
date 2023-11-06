using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Breathing : Activity                     
{
    private string _in;
    private string _out;
    
//Breathing constructors
     public Breathing()
    {
        _in="Breathe in...";
        _out="Breathe out...";
    } 
    public  Breathing(string breathin, string breathout)
    {
        _in= breathin;
        _out= breathout;
    } 

    //Breathing Getters
    public string GetBreathIn()
    {
      string bre=($"{_in}");
      return bre;
    }

    public string GetBreathOut()
    {
       string bre=($"{_out}");
       return bre;
    }
    
    public void BreathInOut(int seconds)
    {    
        Console.Clear();
       
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(seconds);

        while(DateTime.Now < finish)
        {
            Console.WriteLine(GetBreathIn());
            base.Countdown();
            Console.WriteLine();
            Console.WriteLine(GetBreathOut());
            base.Countdown();
            Console.WriteLine();
        }
    }
}









/*class BreathingActivity : Activity
{

    int _breatheInTime = 4;
    int _breatheOutTime = 6;

    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.Write ("Do you want to customize breathing times? (Y/N) ");
        string response = Console.ReadLine();

        if (response[0].ToString().ToLower() == "y")
        {
            _breatheInTime = GetInt("Enter you breathe in time in seconds: ");
            _breatheOutTime = GetInt("Enter your breathe out time in seconds: ");
        }

        GetReady();
        Console.WriteLine("Get ready");

        int _lapsedTime = 0;

        while (_lapsedTime < _duration)
        {
            Console.Write("Breathe in... ");
            CountdownTimer(_breatheInTime);
            Console.Write("\nBreathe out... ");
            CountdownTimer(_breatheOutTime);
            _lapsedTime += _breatheOutTime + _breatheInTime;
        }

    }
}*/