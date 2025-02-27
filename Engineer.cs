
public class Engineer : Employee 
{
private static string specialization = "n/a";

    public static string Specialization 
        {
            get { return Engineer.specialization; }
            set { Engineer.specialization = value; }
        }
    public Engineer (): base ("Unknown",-1.0){}
    
    public override string ToString()
    {
        return $"Engineer: {Name}{Salary}, Specialization:{Specialization}";
    }    
}