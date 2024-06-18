using System;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Security.AccessControl;

public class Job
{
    public string _company;
    public string _name;
    public int _start_year;
    public int _end_year;

    public Job(string company, string name, int start_year, int end_year){
        _company = company;
        _name = name;
        _start_year = start_year;
        _end_year = end_year;
    }
    public void Display(){
        Console.Write($"{_name} ({_company}), {_start_year} - {_end_year}");
    }

}

public class Resume{
    public string _name;
    private List<Job> jobs;
    public Resume(string name, Job job){
        _name = name;
        jobs = new List<Job>();
        jobs.Add(job);
    }

    public void AddJob(Job job){
        jobs.Add(job);
    }
    public void Display(){
        Console.Write($"{_name}\n");
        foreach(Job job in jobs){
            job.Display();
            Console.Write("\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Job tesla = new Job("Tesla", "Engineer", 2019, 2020);
        Job twitch = new Job("Twitch", "Analyst", 2020, 2022);
        Resume juan = new Resume("Juan", tesla);
        juan.AddJob(twitch);
        juan.Display();
    }
}