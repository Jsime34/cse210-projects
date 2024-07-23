class Swimming : Activity{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length){
        _laps = laps;
    }

    public override double getDistance()
    {
        return _laps*50/1000*0.62;
    }

    public override double getSpeed()
    {
        return (getDistance()/(double)getLength()) * 60;
    }

    public override double getPace(){
        return (double)getLength()/getDistance();
    }

}