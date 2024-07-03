class WritingAssignment : Assignment{
    string _title;
    public WritingAssignment(string name, string topic, string title) : base(name, topic){
        _title = title;
    }
    public string GetWritingInformation(){
        string WritingHwork = "";
        WritingHwork += GetSummary();
        WritingHwork += $"\n{_title}";
        return WritingHwork;
    }
}