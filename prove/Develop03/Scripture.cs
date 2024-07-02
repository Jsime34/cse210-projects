using System;

class Scripture{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string name, int chapter, int verse, string text){
        _reference = new Reference(name, chapter, verse);
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach(string i in words){
            Word new_word = new Word(i);
            _words.Add(new_word);
        }
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text){
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach(string i in words){
            Word new_word = new Word(i);
            _words.Add(new_word);
        }
    }

    private int NumberOfHiddenWords(){
        int num_words = 0;
        foreach(Word w in _words){
            if(w.isHidden() == true){
                num_words++;
            }
        }
        return num_words;
    }
    public bool HideSomeWords(){
        bool end = false;
        string new_word = "";
        bool passed_word = false;
        int words = _words.Count();
        int h_words = NumberOfHiddenWords();
        Random rnd = new Random();
        for(int i=0; i<3; i++){
            do{
                passed_word = false;
                int random = rnd.Next(0, words);
                if(_words[random].isHidden() == true){
                    passed_word = false;
                }
                else{
                    int length = _words[random].GetWordLength();
                    for(int j=0; j<length; j++){
                        new_word += "_";
                    }
                    _words[random].SetWord(new_word);
                    _words[random].SetIsHidden(true);
                    passed_word =true;
                }
            }while(passed_word==false);
        }
        h_words = NumberOfHiddenWords();
        if(h_words == words){
            end = true;
        }
        return end;
    }

    public void ShowScripture(){
        foreach(Word w in _words){
            Console.Write($"{w.GetWord()} ");
        }
    }
    public string GetScriptureReference(){
        string reference = _reference.GetScriptureReference();
        return reference;
    }
}