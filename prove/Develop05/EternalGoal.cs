class EternalGoal : SimpleGoal{

    private int _totalpoints;
    public EternalGoal(string name, int points) : base(name, points){
        setType("eternal");
    }

    public EternalGoal(string name, int points, int totalpoints) : base(name, points){
        setType("eternal");
        _totalpoints = totalpoints;
    }
    
    public override int completeGoal()
    {
        _totalpoints += getPoints();
        return getPoints();
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
        info += _totalpoints;
        
        return info;
    }

}