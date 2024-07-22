class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int getNumberofComments(){
        int number = 0;
        foreach(Comment c in _comments){
            number++;
        }
        return number;
    }

    public void createComment(string author, string content){
        Comment new_c = new Comment(author, content);
        _comments.Add(new_c);
    }

    public string getInfo(){
        string info = "";
        info += $"Title: {_title}\n";
        info += $"Author: {_author}\n";
        info += $"Length: {_length} seconds\n";
        info += $"Number of comments: {getNumberofComments()}\n";
        info += "\n";
        foreach(Comment c in _comments){
            info+= $"{c.getAuthor()}\n";
            info+= $"{c.getContent()}\n";
            info+= "\n";
        }
        return info;
    }
}