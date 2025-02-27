public class Manager : Employee 
{
    private static int numberOfEmployeeManaged = -1;
    
    public static int NumberOfEmployeeManaged
    { 
        get { return Manager.numberOfEmployeeManaged; }
        set { Manager.numberOfEmployeeManaged = value; }
    }

    public Manager (): base ("Unknown",-1.0){}
    
    public override string ToString()
    {
        return $"Manager: {Name}{Salary}, Number of Employee managed:{NumberOfEmployeeManaged}";
    }

}