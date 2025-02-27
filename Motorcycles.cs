public class Motorcycles : Vehicles
{
    private static bool hasSidecar = false;

    public static bool HasSidecar
    {
        get{ return Motorcycles.hasSidecar ;}
        set {Motorcycles.HasSidecar = value; }

    }
    public Motorcycles (): base ("unknown","Motorcycles",2005){}

    public override string ToString()
    {
        return $"Year {Year} Make {Make} Model{Model} Has Sidecar:{HasSidecar}";
    }
}