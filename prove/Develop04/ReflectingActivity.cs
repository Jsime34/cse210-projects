class ReflectingActivity : Activity{
    List<string> _Prompts;
    List<string> _Strings;

    public ReflectingActivity(){
        _Prompts = new List<string>();
        _Prompts.Add("Think of a time when you stood up for someone else.\n");
        _Prompts.Add("Think of a time when you did something really difficult.\n");
        _Prompts.Add("Think of a time when you helped someone in need\n");
        _Prompts.Add("Think of a time when you did something truly selfless.\n");
        _Strings = new List<string>();
        _Strings.Add("Why was this experience meaningful to you?\n");
        _Strings.Add("Have you ever done anything like this before?\n");
        _Strings.Add("How did you get started?\n");
        _Strings.Add("How did you feel when it was complete?\n");
        _Strings.Add("What made this time different than other times when you were not as succesful?\n");
        _Strings.Add("What is your favorite thing about this experience?\n");
        _Strings.Add("What could you learn from this experience that applies to other situations?\n");
        _Strings.Add("What did you learn about yourself through this experience?\n");
        _Strings.Add("How can you keep this experience in mind in the future?\n");
        setName("Reflecting activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
    }
    public void Prompt(){
        Random rnd = new Random();
        int seconds = SetSeconds();
        int randomnum = rnd.Next(0,_Prompts.Count());
        Console.WriteLine($"{_Prompts[randomnum]}");
        PauseCountdown(seconds);
        randomnum = rnd.Next(0, _Strings.Count());
        Console.WriteLine($"{_Strings[randomnum]}");
        PauseSpinner(seconds);
        randomnum = rnd.Next(0, _Strings.Count());
        Console.WriteLine($"{_Strings[randomnum]}");
        PauseCountdown(seconds);
        randomnum = rnd.Next(0, _Strings.Count());
        Console.WriteLine($"{_Strings[randomnum]}");
        PauseSpinner(seconds);
        DisplayEnd();
    }
    public int SetSeconds(){
        Console.Write("Insert the seconds you want to breath: \n");
        string seconds = Console.ReadLine();
        int _seconds = int.Parse(seconds);
        return _seconds;
    }
    public void Question(){
        Random rnd = new Random();
        int randomnum = rnd.Next(0,_Prompts.Count());
    }

    public void GetAnswer(){
        Random rnd = new Random();
        int randomnum = rnd.Next(0,_Strings.Count());
        Console.WriteLine($"{_Prompts[randomnum]}");       
    }
}