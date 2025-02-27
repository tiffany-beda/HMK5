public class Car : Vehicles 
{
    private static int numberOfDoors = -1;

    public static int NumberOfDoors
    {
        get {return Car.numberOfDoors ;}
        set {Car.numberOfDoors = value; }
    } 
    public Car () : base ("UNKNOWN","CAR",2000)
    {}
    // Public Car ()
    // {
    // this.make = false;
    //  this.model = "car";
    //  this.year = 2000;
    //  }

    public override string ToString()
    {
        return $"Year {Year} Make {Make} Model{Model} with {NumberOfDoors} doors";
    }
}