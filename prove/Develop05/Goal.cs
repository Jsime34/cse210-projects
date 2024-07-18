class SimpleGoal{
    private string _name;
    private int _points;
    private bool _completed;
    private string _type;

    public SimpleGoal(string name, int points){
        _name = name;
        _points = points;
        _completed = false;
        _type = "simple";
    }

    public SimpleGoal(string name, int points, bool completed){
        _name = name;
        _points = points;
        _completed = false;
        _type = "simple";
    }

    public virtual int completeGoal(){
        _completed = true;
        return _points;
    }

    public bool getcompleted(){
        return _completed;
    }

    public void setcompleted(bool value){
        _completed = value;
    }

    public virtual int getPoints(){
        return _points;
    }

    public string getName(){
        return _name;
    }

    public string getType(){
        return _type;
    }

    public void setType(string type){
        _type = type;
    }

    public virtual string getInfo(){
        string info = "";
        info+=_type;
        info+=":";
        info+=_name;
        info+=":";
        info+=_points;
        info+=":";
        info+=_completed;
        return info;
    }
}