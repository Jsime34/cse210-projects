class BreathingActivity : Activity{
    List<string> _Prompts;

    public BreathingActivity(){
        _Prompts = new List<string>();
        _Prompts.Add("Breath in...");
        _Prompts.Add("Breath out...");
        SetDescription("This activity will help you relax by by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        setName("Breathing activity");
    }
    public void runBreathing(){
        SetSeconds();
        for(int i=0; i<5; i++){
            Console.WriteLine("Breath in...");
            PauseCountdown(getDuration());
            Console.WriteLine("Breath out...");
            PauseSpinner(getDuration());
        }
        DisplayEnd();
        System.Environment.Exit(0);
    }
    public void SetSeconds(){
        Console.Write("Insert the seconds you want to breath: \n");
        string seconds = Console.ReadLine();
        setDuration(int.Parse(seconds));
    }
}