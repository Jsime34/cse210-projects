class Cycling : Activity{
    private double _speed;

    public Cycling(string date, int length, double speed)
        :base(date, length){
            _speed = speed;
    }

    public override double getDistance()
    {
        return (_speed/(double)getLength())/60;
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        return (double)60/_speed;
    }
}