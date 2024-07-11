using System;
class ListingActivity : Activity{
    List<string> _Prompts;
    
    public ListingActivity(){
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
        setName("Listing Activity");
        _Prompts = new List<string>();
        _Prompts.Add("Who are people that you appreciate?");
        _Prompts.Add("What are personal strengths of yours?");
        _Prompts.Add("Who are people that you have helped this week?");
        _Prompts.Add("When have you felt the Holy Ghost this month?");
        _Prompts.Add("Who are some of your personal heroes?");
    }
    public void RunListing(){
        int items = setItems();
        SetSeconds();
        Random rnd = new Random();
        int random = 0;
        for(int i=0; i<items; i++){
            random = rnd.Next(0,_Prompts.Count());
            Console.WriteLine($"{_Prompts[random]}");
            PauseCountdown(getDuration());
            string answer = Console.ReadLine();
        }
        Console.WriteLine($"You inserted {items} items");
        DisplayEnd();
        
    }
    public int setItems(){
        Console.Write("Insert the items you want to insert: \n");
        string _items = Console.ReadLine();
        int items = int.Parse(_items);
        return items;
    }

    public void SetSeconds(){
        Console.Write("Insert the seconds you want to breath: \n");
        string seconds = Console.ReadLine();
        setDuration(int.Parse(seconds));
    }
}