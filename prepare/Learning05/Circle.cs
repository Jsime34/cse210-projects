class Circle:Shape{
    private double _radius;

    public Circle (string color, double radius) : base(color){
        _radius = radius;
        setColor(color);
    }

    public override double GetArea()
    {
        double PI = 3.1415926535897931;
        return PI*_radius*_radius;
    }
}