using System.Collections;
using System.Net.Http.Headers;
using System.IO;

class User{
    private string _name;
    private int _points;
    private List<SimpleGoal> _goals;

    public User(string name){
        _name = name;
        _points = 0;
        _goals = new List<SimpleGoal>();
    }

    public void ShowPrompt(){
        string option = "0";
        string newgoal;
        int newpoints;
        string points;
        while(option != "10"){
            Console.WriteLine("Welcome to the Goal designer!");
            Console.WriteLine("Select your option: ");
            Console.WriteLine("1. Create a simple goal.");
            Console.WriteLine("2. Create an eternal goal.");
            Console.WriteLine("3. Create a checklist goal.");
            Console.WriteLine("4. Save a file.");
            Console.WriteLine("5. Load a file.");
            Console.WriteLine("6. Complete a goal.");
            Console.WriteLine("7. See your completed goals.");
            Console.WriteLine("8. See your not yet completed goals.");
            Console.WriteLine("9. See your current score.");
            Console.WriteLine("10. Exit.");
            Console.WriteLine("Select your number: ");
            option = Console.ReadLine();
            int optionr = int.Parse(option);
                switch(optionr){
                    case 1:
                        Console.WriteLine("Insert the new name of your goal: ");
                        newgoal = Console.ReadLine();
                        Console.WriteLine("How many points is it going to be worth? ");
                        points = Console.ReadLine();
                        newpoints = int.Parse(points);
                        SimpleGoal new_goal = new SimpleGoal(newgoal, newpoints);
                        _goals.Add(new_goal);
                        break;
                    case 2:
                        Console.WriteLine("Insert the new name of your goal: ");
                        newgoal = Console.ReadLine();
                        Console.WriteLine("How many points is it going to be worth each time you complete it? ");
                        points = Console.ReadLine();
                        newpoints = int.Parse(points);
                        EternalGoal new_et_goal = new EternalGoal(newgoal, newpoints);
                        _goals.Add(new_et_goal);
                        break;
                    case 3:
                        Console.WriteLine("Insert the new name of your goal: ");
                        newgoal = Console.ReadLine();
                        Console.WriteLine("How many points is it going to be worth each time you complete it? ");
                        points = Console.ReadLine();
                        newpoints = int.Parse(points);
                        Console.WriteLine("How many times do you have to do this to fulfill your goal?");
                        string timesc = Console.ReadLine();
                        int times = int.Parse(timesc);
                        ChecklistGoal new_check_goal = new ChecklistGoal(newgoal, newpoints, times);
                        _goals.Add(new_check_goal);
                        break;
                    case 4:
                        Save();
                        break;
                    case 5:
                        Load();
                        break;
                    case 6:
                        int opt = 0;
                        foreach(SimpleGoal sh in _goals){
                            if(sh.getcompleted() == false){
                                Console.Write($"{opt+1}. ");
                                Console.WriteLine(sh.getName());
                                Console.WriteLine(sh.getPoints());
                                opt++;
                            }
                        }
                        Console.WriteLine("Select the goal you want to complete: ");
                        string snumber = Console.ReadLine();
                        int snumber_int = int.Parse(snumber);
                        _points += _goals[snumber_int-1].completeGoal();
                        break;
                    case 7:
                        foreach(SimpleGoal sh in _goals){
                            if(sh.getcompleted()==true){
                                Console.WriteLine(sh.getName());
                                Console.WriteLine(sh.getPoints());
                            }
                        }
                        break;
                    case 8:
                        foreach(SimpleGoal sh in _goals){
                            if(sh.getcompleted()==false){
                                Console.WriteLine(sh.getName());
                                Console.WriteLine(sh.getPoints());
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine($"Dear {_name}, your current score is: {_points}");
                        break;
                    case 10:
                        System.Environment.Exit(0);
                        break;
            }
        }
    }
    public void ShowGoals(){
        foreach(SimpleGoal s in _goals){
            if(s.getcompleted()==false){
                Console.WriteLine($"Name of the goal: {s.getName()}\n");
                Console.WriteLine($"Points given by this goal: {s.getPoints()}");
            }
        }
    }
    public void ShowCompletedGoals(){
        foreach(SimpleGoal s in _goals){
            if(s.getcompleted()==true){
                Console.WriteLine($"Name of the goal: {s.getName()}\n");
                Console.WriteLine($"Points given by this goal: {s.getPoints()}");
            }
        }
    }
    public void Save(){
        string filename;
        Console.WriteLine("Insert the name of the filename: ");
        filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename)){
            foreach(SimpleGoal s in _goals){
                outputFile.WriteLine(s.getInfo());
            }
        }
    }
    public void Load(){
        _goals.Clear();
        _points = 0;
        string filename;
        Console.WriteLine("Insert the name of the filename: ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines){
            string[] parts = line.Split(":");
            string type = parts[0];
            if(type == "simple"){
                int spoints = int.Parse(parts[2]);
                bool scompleted = bool.Parse(parts[3]);
                SimpleGoal s = new SimpleGoal(parts[1], spoints, scompleted);
                if(scompleted == true){
                    _points += spoints;
                }
                _goals.Add(s);
            }
            else if(type == "checklist"){
                int cpoints = int.Parse(parts[2]);
                bool ccompleted = bool.Parse(parts[3]);
                int ctimes = int.Parse(parts[4]);
                int cnumcompleted = int.Parse(parts[5]);
                ChecklistGoal cg = new ChecklistGoal(parts[1], cpoints, ccompleted, ctimes, cnumcompleted);
                _points += cg.getPoints();
                _goals.Add(cg);
            }
            else if(type == "eternal"){
                int epoints = int.Parse(parts[2]);
                int etpoints = int.Parse(parts[4]);
                EternalGoal eg = new EternalGoal(parts[1], epoints, etpoints);
                _points += etpoints;
                _goals.Add(eg);
            }
        }
    }
}



