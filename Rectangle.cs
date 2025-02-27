public abstract class  Rectangle : Shape
{
    private static int height = -1;
    private static int width = -1;

    public int Height 
    {
        get { return Rectangle.height ;}
        set { Rectangle.height = value ;}
    }
    public int Width 
    {
        get { return Rectangle.width; }
        set { Rectangle.width = value; }
    }

    public Rectangle (string _color ,int _height, int _width): base (_color)
    {
        this.Height = _height;
        this.Width = _width;
    }

    public override double GetArea()
    {
        return Width * Height ;
    }
    public override string ToString()
    {
        return $"{Color} Rectangle with an area: {GetArea()}";

    }
}