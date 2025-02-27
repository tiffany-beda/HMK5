public abstract class Shape 
{
    private string color = "Undecided";

    public string Color 
    { 
        get { return this.color;}
        set { this.color = value;}
    }
    
    public Shape (): this ("Undecided") {}
    public Shape (string _color)
    { 
        this.Color = _color;
    }
    public  abstract double  GetArea();
    public override string ToString()
    {
        return $"Color Shape: {Color}";
    }

}