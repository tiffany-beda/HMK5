public class Animal 
{
    private string name = "Unknown";

    public string Name 
    {
        get {return this.name;}
        set {this.name = value;}
    }
    public Animal ():this ("Unknown"){}
    public Animal (string _name)
    {
        this.Name = _name;
    }

    public virtual string MakeSound()
    {
        return "Some general animal sound";
    }
    public override string ToString()
    {
        return $"Animal: {Name},Sounds: {MakeSound()}" ;
    }
}
