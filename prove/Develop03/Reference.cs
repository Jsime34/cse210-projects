using System;

class Reference{
    private string _bookName;
    private int _chapter;
    private List<int> _verse;

    public Reference(string name, int chapter, int verse){
        _bookName = name;
        _chapter = chapter;
        _verse = new List<int>();
        _verse.Add(verse);
    }

    public Reference(string name, int chapter, int startVerse, int endVerse){
        _bookName = name;
        _chapter = chapter;
        _verse = new List<int>();
        _verse.Add(startVerse);
        _verse.Add(endVerse);
    }

    private string GetScriptureReferenceString(){
        string scrips = "";
        if(_verse.Count == 1){
            scrips+= $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else{
            scrips+= $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
        return scrips;
    }

    public void ShowScriptureReference(){
        Console.Write($"{GetScriptureReferenceString()}\n");
    }

    public string GetScriptureReference(){
        string scrips = GetScriptureReferenceString();
        return scrips;
    }
}