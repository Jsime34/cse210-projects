using System.Drawing;

class ChecklistGoal : SimpleGoal{
    private int _times;
    private int _number_completed;
    public ChecklistGoal(string name, int points, int times) : base(name, points){
        _times = times;
        _number_completed = 0;
        setType("checklist");
    }

    public ChecklistGoal(string name, int points, bool completed, int times, int tcompleted) : base(name, points, completed){
        _times = times;
        _number_completed = tcompleted;
        setType("checklist");
    }

    public override int completeGoal()
    {
        _number_completed++;
        if(_number_completed==_times){
            setcompleted(true);
        }
        return getPoints()/_times;
    }

    public override int getPoints()
    {
        return (getPoints()/_times) * _number_completed;
    }

    public override string getInfo()
    {
        string info = "";
        info += getType();
        info+= ":";
        info += getName();
        info += ":";
        info += getPoints();
        info += ":";
        info += getcompleted();
        info += ":";
        info += _times;
        info += ":";
        info += _number_completed;
        
        return info;
    }
}