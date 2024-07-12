using System.Drawing;

class Shape{
    private string _color;

    public Shape(string color){
        _color = color;
    }

    public void setColor(string color){
        _color = color;
    }

    public string getColor(){
        return _color;
    }

    public virtual double GetArea(){
        int a = 0;
        return a;
    }
}