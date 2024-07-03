using System;
class Assignment{
    private string _student_name;
    private string _topic;

    public Assignment(string student_name, string topic){
        _student_name = student_name;
        _topic = topic;
    }
    public string GetSummary(){
        string summary = "";
        summary += $"\n{_student_name}, ";
        summary += $"{_topic}";
        return summary;
    }
}