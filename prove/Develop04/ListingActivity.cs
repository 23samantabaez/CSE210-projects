using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Listing : Activity                     
{
   
    protected List<string> _questionList;
    protected string _userRes;
    
    protected string _question;

    public Listing()
    {
        _questionList= new List<string>() {"When have you felt the Holy Ghost this month?","What did you learn today","Which scripture cames to you mind and why?","If a loved persone were with you, what would you say to them?","What is patience yo you?","What is perseverence to you? tell me an example."};
        _userRes = "";
    } 
   
    public string GetLisQue()
    {
      Random random = new Random();
      int index = random.Next( _questionList.Count);
      _question =  _questionList[index];
      return _question;

    }
    public void GetLisResp()
    {
        Console.Write("> ");
        _userRes = Console.ReadLine();
    }

    public void ListCore(int seconds)
    {   
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(GetLisQue()); 
        Console.ResetColor();
        base.Countdown();
        
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(seconds);
       
        while(DateTime.Now < finish)
        {
            GetLisResp();
        }

        Console.WriteLine("Well done!! ");   
    }
}