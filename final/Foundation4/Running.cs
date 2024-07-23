class Running:Activity{
    private double _distance;

    public Running(string date, int length, double distance)
        :base(date, length){
            _distance = distance;
        }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getSpeed()
    {
        return (_distance/(double)getLength()) * 60;
    }

    public override double getPace()
    {
        return (double)getLength()/_distance;
    }
}