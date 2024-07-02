using System;

class Word{
    private string _word;
    private bool _hidden;

    public Word(string word){
        _word = word;
        _hidden = false;
    }

    public void SetWord(string word){
        _word = word;
    }
    public bool isHidden(){
        return _hidden;
    }

    public void SetIsHidden(bool hidden){
        _hidden = hidden;
    }

    public string GetWord(){
        return _word;
    }

    public int GetWordLength(){
        return _word.Length;
    }
}