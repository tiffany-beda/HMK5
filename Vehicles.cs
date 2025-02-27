using System.Reflection.Metadata;

public class Vehicles 
{
private string make = "n/a";
private string model = "n/a";
private int year = -1;

public string Make
{
get { return this.make; }
set { this.make = value; }
}
public string Model 
{
    get { return this.model ;}
    set { this.model = value; }
}
public int Year 
{
    get { return this.year ; }
    set { this.year = value;  }
}
public Vehicles (): this("n/a","n/a",-1){}
public Vehicles (string _make, string _model, int _year)
{
    this.make = _make;
    this.model = _model;
    this.year = _year;
}
    public override string ToString()
    {
        return $"Year {Year} Make {Make} Model{Model}";
    }
}