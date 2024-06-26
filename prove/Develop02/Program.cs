using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Journal{
    private List<string> prompt;
    public Dictionary<int, Entry> entries;
    public int last_number = 0;

    public Journal(){
        prompt = new List<string>();
        prompt.Add("1. Insert new entry");
        prompt.Add("2. Save the journal to a file");
        prompt.Add("3. Load new journal from a file");
        prompt.Add("4. Display the journal");
        prompt.Add("5. Exit");
        entries = new Dictionary<int, Entry>();
    }
    public void DisplayPrompt(){
        int action = 0;
        foreach(string i in prompt){
            Console.Write($"{i}\n");
        }
        Console.Write("Insert your action: ");
        string actions = Console.ReadLine();
        action = int.Parse(actions);
        switch(action){
            case 1:
                InsertEntry();
                break;
            case 2:
                submitFile();
                break;
            case 3:
                loadFile();
                break;
            case 4:
                display();
                break;
            case 5:
                break;
        }
    }

    public void InsertEntry(){
        last_number++;
        Entry new_entry = new Entry();
        new_entry.DisplayPrompt();
        entries.Add(last_number, new_entry);
    }

    public void submitFile(){
        string filename = "";
        string entry_text = "";
        Console.Write("Insert the name of your file(Don't forget the .txt. If you don't have one type 'No'): ");
        filename = Console.ReadLine();
        if(filename == "No"){
            filename = "New_file.txt";
        }
        using(StreamWriter outputFile = new StreamWriter(filename)){
            foreach(KeyValuePair<int, Entry> entry in entries){
                entry_text = entry.Value.getText();
                outputFile.Write($"{entry_text}");
            }
        }
    }

    public void loadFile(){
        entries.Clear();
        last_number = 1;
        string filename = "";
        Console.Write("Insert the name of your file(Don't forget the .txt. If you don't have one type 'No'): ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("✣");
            string date = parts[0];
            string text = parts[1];
            text += parts[2];
            Entry newEntry = new Entry();
            newEntry.date = date;
            newEntry.text.Add(text);
            entries.Add(last_number, newEntry);
            last_number++;
        }
    }
    public void display(){
        foreach(KeyValuePair<int, Entry> entry in entries){
            string display_text = entry.Value.getText();
            Console.Write($"{display_text}\n");
        }
    }
}

class Entry{
    public List<string> prompt;
    public string date;
    public List<string> text;

    public Entry(){
        prompt = new List<string>();
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("How did I see the hand of the Lord in my life today?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("If I had one thing I could do over today, what would it be?");
        text = new List<string>();
    }

    public void DisplayPrompt(){
        string add_text = "";
        string keepgoing = "Yes";
        string is_in = "False";
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        do{
            is_in = "False";
            int rand_num = rnd.Next(0, 5);
            foreach(int i in numbers){
                if(rand_num == i){
                    is_in= "True";
                    keepgoing = "Yes";
                }
            }
            if(is_in=="False"){
                numbers.Add(rand_num);
                add_text+=$"{prompt[rand_num]}✣";
                Console.Write($"{prompt[rand_num]}\n");
                add_text+=Console.ReadLine();
                text.Add(add_text);
                Console.Write("Do you want to answer another question? (Yes/No)");
                keepgoing = Console.ReadLine();
            }
        }while(keepgoing == "Yes");
        DateTime date_n = DateTime.UtcNow.Date;
        date = date_n.ToString();
    }
    public void insertText(string texti){
        text.Add(texti);
    }
    public void DisplayText(){
        Console.Write($"{date}\n");
        foreach(string i in text){
            Console.Write($"{i}\n");
        }
    }
    public string getText(){
        string entry_text = "";
        entry_text+= $"{date}✣";
        foreach(string i in text){
            Console.Write(i);
            entry_text+=($"{i}");
        }
        entry_text += "\n";
        return entry_text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal our_journal = new Journal();
        string next = "No";
        do{
            our_journal.DisplayPrompt();
            Console.Write("Do you wish to make another command? (Yes/No) ");
            next = Console.ReadLine();
        }while(next=="Yes");
    }
}