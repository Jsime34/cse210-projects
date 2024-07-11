using System;
using System.Collections;

class Activity
{
    private string _Activityname;
    private string _Description;
    private int _Duration;
    public void DisplayStart(){
        string rpta = "";
        BreathingActivity breath = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        Console.Write("Welcome to the Mindfulness program.\n");
        Console.Write("Please select an activity: \n");
        Console.Write("1. Breathing Activity. \n");
        Console.WriteLine($"{breath._Description}");
        Console.Write("2. Listing Activity. \n");
        Console.WriteLine($"{listing._Description}");
        Console.Write("3. Reflecting Activity. \n");
        Console.WriteLine($"{reflect._Description}");
        Console.Write("Select your number, or press another key to quit: \n");
        rpta = Console.ReadLine();
        if(rpta == "1"){
            breath.runBreathing();
        }
        else if(rpta == "2"){
            listing.RunListing();
        }
        else if(rpta == "3"){
            reflect.Prompt();
        }
        else{
            DisplayEnd();
            System.Environment.Exit(0);
        }
    }
    public void DisplayEnd(){
        Console.Write("Nice job user. Keep going like that! \n");
    }
    public void PauseSpinner(int seconds){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= animationStrings.Count){
                i=0;
            }

        }
        Console.WriteLine("Done");
    }
    public void PauseCountdown(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        while(DateTime.Now < endTime){
            int s = seconds;
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds--;
        }
        Console.WriteLine("Done");
    }
    public void SetDescription(string description){
        _Description = description;
    }

    public string getDescription(){
        return _Description;
    }

    public void setName(string name){
        _Activityname = name;
    }

    public string getName(){
        return _Activityname;
    }

    public void setDuration(int duration){
        _Duration = duration;
    }

    public int getDuration(){
        return _Duration;
    }
}