public abstract class Circle : Shape
{
private static int radius = -1;

    public  int Radius 
        {
        get { return Circle.radius; }
        set { Circle.radius = value; }
        }

    public Circle (string _color, int _radius): base (_color)
    {
        this.Radius = _radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override string ToString()
    {
        return $"{Color} Circle with an area: {GetArea()}";
    }
}