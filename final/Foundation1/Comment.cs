class Comment{
    private string _author;
    private string _content;

    public Comment(string author, string content){
        _author = author;
        _content = content;
    }

    public void setAuthor(string author){
        _author = author;
    }

    public string getAuthor(){
        return _author;
    }

    public void setContent(string content){
        _content = content;
    }

    public string getContent(){
        return _content;
    }
}