public abstract class Activity{
    private string _date;
    private int _length;

    public Activity(string date, int length){
        _date = date;
        _length = length;
    }

    public abstract double getDistance();
    public abstract double getSpeed();
    public abstract double getPace();

    public virtual string getSummary(){
        string summary = $"{_date} {GetType().Name} ({_length} min)\n distance: {getDistance():0.0} miles,\n speed: {getSpeed():0.0} mph,\n pace: {getPace():0.0} min per mile";
        return summary;
    }

    public int getLength(){
        return _length;
    }

    public string getDate(){
        return _date;
    }
}