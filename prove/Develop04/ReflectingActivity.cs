using System;
using System.Collections.Generic;
using System.IO;

class Reflecting : Activity                     
{
    private string _prompt;
    private string _question;
   
    protected string[] _questions;
    protected string[] _prompts;

    public Reflecting()
    {
        _prompt="";
        _question="";
       
        _questions = new string [] {"Why was this experience meaningful to you?",
                                    "Have you ever done anything like this before?",
                                    "How did you get started?",
                                    "How did you feel when it was complete?",
                                    "What made this time different than other times when you were not as successful?",
                                    "What is your favorite thing about this experience?",
                                    "What could you learn from this experience that applies to other situations?",
                                    "What did you learn about yourself through this experience?",
                                    "How can you keep this experience in mind in the future?"};
                                    
        _prompts = new string[] {"Think of a time when you stood up for someone else.",
                                "Think of a time when you did something really difficult.",
                                "Think of a time when you helped someone in need.",
                                "Think of a time when you did something truly selfless."};

    } 
    public void SetPrompts(string[] prompts)
    {
        _prompts= prompts;
    }
    public void SetQuestions(string[] questions)
    {
        _questions= questions;
    }


    public string GetPro()
    {
        string prom=($"{_prompt}");
        return prom;
    }
    
    public string GetQue()
    {
        string ques=($"{_question}");
        return ques;
    }

    public string RandomPro()
    {
        
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        _prompt = _prompts[index];
        
        return _prompt;
        
    }
    public string RandomQue()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Length);
        _question = _questions[index];
        return _question;
    }

    public void Reflectioning(int segundos)
    {   
        Console.Clear();
        Console.WriteLine("Consider the following prompt");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(RandomPro());
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("When you something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        base.Countdown();
       
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {
            Console.WriteLine(RandomQue());
            base.Countdown();
            
        }
        Console.WriteLine("Well done!! ");
    }
}




/*using System;
using System.Collections.Generic;
using System.IO;


class ReflectingActivity : Activity
{
    private string _prompt;
    private string _question;
    protected string [] _questions;
    protected string [] _prompts;

    public ReflectingActivity()
    {
        _prompt = "";
        _question = "";

        _prompts = new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new string[] {
            "Why was this experience meaningful to you?",",
            "Have you ever done anything like this before?",",
            "How did you get started?",",
            "How did you feel when it was complete?",",
            "What made this time different than other times when you were not as successful?",",
            "What is your favorite thing about this experience?",",
            "What could you learn from this experience that applies to other situations?",",
            "What did you learn about yourself through this experience?",",
            "How can you keep this experience in mind in the future?","
        };
    }

    public void SetPrompts(string[] prompts)
    {
        _prompts = prompts;
    }

    public void SetQuestions(string[] questions)
    {
        _questions = questions;
    }

    public string GetPrompt()
    {
        string prompt = ($"{_prompt}");
        return prompt;
    }

    public string GetQuestion()
    {
        string question = ($"{_question}");
        return question;
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        _prompt = _prompts [index];
        return _prompt;
    }

    public string RandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Length);
        _question = _questions[index];
        return _question;
    }

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(RandomPrompt());
        Console.WriteLine();
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions: ");

        base.CountdownTimer();

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(_duration); // Use begin.AddSeconds() to calculate finish time

        while (DateTime.Now < finish)
        {
            Console.WriteLine(RandomQuestion());
            base.CountdownTimer();
        }

        DisplayEndingMessage(); // Assuming DisplayEndingMessage() is a method defined in your Activity class
    }
}
/*



    public void Reflectioning(int _duration)
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        //Console.ForegroundColor = Console.Yellow;
        Console.WriteLine(RandomPrompt());
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions: ");

        base.CountdownTimer();

        DateTime begin = DateTime.Now;
        DateTime finish = DateTime.AddSeconds(_duration);

        while (DateTime.Now < finish)
        {
            Console.WriteLine(RandomQuestion());
            base.CountdownTimer();
        }

        DisplayEndingMessage();

    }
}


    /*private List<string> _refPromptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",",
        "Have you ever done anything like this before?",",
        "How did you get started?",",
        "How did you feel when it was complete?",",
        "What made this time different than other times when you were not as successful?",",
        "What is your favorite thing about this experience?",",
        "What could you learn from this experience that applies to other situations?",",
        "What did you learn about yourself through this experience?",",
        "How can you keep this experience in mind in the future?","
    };


    public string GetNextQuestion()
    {
        foreach (var _question in _questions)
        {
            Console.WriteLine(_question);
        }
    }

    int _currentQuestion = 0;

    public ReflectingActivity() : base()
    {
        _activityName = "Reflection Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private string GetRefPrompt()
    {
        var rnd = new Random();
        return _refPromptList[rnd.Next(_refPromptList.Count)];
    }

    private void DisplayQuestions(int _questioDuration = 6)
    {
        int _questionQuantity = _duration/_questionDuration;
        
        if(_questions.Count - _currentQuestion < _questionQuantity) 
        {
            RandomizeList(ref _questions);
            _currentQuestion = 0;
        }

        for (int i = 0; i < _questionQuantity; i++)
        {
            Console.Write($"> {GetNextQuestion()} ");
            SpinnerPause(_questionDuration);
            Console.WriteLine();
        }
        _duration = _questionQuantity * _questionDuration;
    }

    private void RandomizeList(ref List<string> toMakeRandom)
    {
        List<string> tempList = new List<string> {};
        tempList = toMakeRandom;
        var rnd = new Random();
        toMakeRandom = tempList.OrderBy(_=> rnd.Next()).ToList();
    }


    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine($"--- {GetRefPrompt()} ---");
        CountdownTimer(5);
        DisplayQuestions();
        DisplayEndingMessage();
    }*/

