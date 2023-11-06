using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Activity                    
{
    protected int _seconds;
    protected string _actName;
    protected string _actAbout;
   

    public Activity()
    {
       _actName =" ";
       _actAbout = " ";
      
    } 

    public Activity(string actName, string actAbout, int seconds)
    {
       _actName = actName;
       _actAbout = actAbout;
       _seconds = seconds;
       
    } 
    
    public int GetSecondes()
    {
      return _seconds;
    }

    public void SetSecondes(int seconds)
    {
      _seconds = seconds;
    }

    public string GetActName()
    {
       return _actName;
    }
    
    public string GetActAbout()
    {
       
       return _actAbout;
    }

    public void SetActName(string actName)
    {
       _actName = actName;
    }

    public void SetActAbout(string actAbout)
    {
       _actAbout = actAbout;
    }


    public string GetWelcome()
    {
      return $"Welcome to the {_actName} activity\n{_actAbout}";
    }

    
    public void MethodSpin()
    {
        Console.WriteLine("Get ready");

        List<string> animation = new List<string>();

        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        

        foreach (string a in animation)
            {
                Console.Write(a);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
    }

    public string MethodBye()
    {
      return ($"You have completed another {_seconds} sec of {_actName} Activity. ");
    }

    public int MethodTimer()
    {
        Console.WriteLine("How long in seconds, would you like for your session? Ex. 10,20,30");
        _seconds = int.Parse(Console.ReadLine());
        return _seconds;
    }
        
    protected void Countdown()
    {
        for(int i = 5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

/*public class Activity
{
    string _activityName = "";
    string _activityDescription = "";
    int _duration = 30;
    string _durationPrompt = "How long, in seconds, would you like your activity to last?";
    string _endMessage = "Well done! \n";

    public Activity()
    {
        //nothing here
    }

    public void SetName(string _name)
    {
        _activityName = _name;
    }

    public void SetDescription(string _description) 
    {
        _activityDescription = _description;
    }

    // ***
    public void SetDuration(int _activityDuration)
    {
        _duration = _activityDuration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to {_activityName}! ");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        _duration = GetInt(_durationPrompt);
    }

    public string GetEndingMessage()
    {
        return _endMessage;
    }

    public void DisplayEndingMessage(int _spinnerDuration = 5)
    {
        Console.WriteLine("Well Done!");
        SpinnerPause(_spinnerDuration);
        Console.WriteLine($"You completed another {_duration} seconds of {_activityName}.");
        SpinnerPause(_spinnerDuration);
    }

    public void SpinnerPause(int _spinnerDuration = 5)
    {
        List<string> charSequence = new List<string> {"|", "\\", "|", "/" };
        //int runs = 0;
        int charPause = 1000;

        for (int runs = 0; runs*charPause < _spinnerDuration*1000; runs++)
        {
            Console.Write(charSequence[runs % 4]);
            Thread.Sleep(charPause);
            runs ++;
            Console.Write("\b \b");
        }
    }

    public void CountdownTimer(int _countdownDuration = 6)
    {
        for(int i = _countdownDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i < 10)
            {
                Console.Write("\b \b");
            }

            else if (i < 100)
            {
                Console.Write("\b\b \b\b");
            }

            else if (i < 1000)
            {
                Console.Write("\b\b\b \b\b\b");
            }
        }
    }

    public static int GetInt(string _message)
    {
        bool inputSuccess = false;
        int _returnValue = 0;

        while (!inputSuccess) //while loop in case the user does not type a value/option from the given menu/list of activities
        {
            Console.WriteLine();
            Console.WriteLine(_message);
            inputSuccess = int.TryParse(Console.ReadLine(), out _returnValue);

            if (!inputSuccess)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        return _returnValue;
    }

    public void GetReady(int _spinnerDuration = 5)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(_spinnerDuration);
        Console.WriteLine();
    }
}*/

