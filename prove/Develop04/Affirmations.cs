using System;
using System.Collections.Generic;
using System.IO;

class Positive : Activity
{
    protected string _message;
    protected string [] _messages = new string[]{};

    public Positive (string message)
    {
        _message = message;
    }

    public Positive()
    {
        _messages = new string[]{"I am enough.",
                                "I believe in myself.",
                                "I attract positive people into my life.",
                                "The hardest challenges are the biggest growth opportunities.",
                                "I am resilient."};
    }

    public string RandomPosi()
    {
        Random random = new Random();
        int index = random.Next(0, _messages.Length);
        _message = _messages[index];
        return _message;
    }

    public void Confidence (int seconds)
    {
        Console.WriteLine("Take a deep breath... ");
        base.Countdown();
        Console.WriteLine("Say out loud the following phrase");
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(seconds);

        while(DateTime.Now < finish)
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(RandomPosi());
            Console.ResetColor();
            
            for (int i = 3; i>0; i--)
            {
                Console.Write(" . ");
                Thread.Sleep(1000);
                Console.WriteLine("\b \b");
            }
        }
        Console.WriteLine("Well done!! ");
    }
}