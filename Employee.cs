using System.ComponentModel;

public class Employee
{
private string name = "n/a";
private double salary = -1.0;

public string Name 
{
    get { return this.name; }
    set { this.name = value ; }

}
public double Salary 
{
    get { return this.salary; }
    set { this.salary = value; }
}
public Employee(): this ("n/a",-1.0){}
public Employee (string _name, double _salary )
{
this.Name = _name ;
this.Salary = _salary ;
}


}