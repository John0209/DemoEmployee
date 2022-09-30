using DemoEmployee.Per;

namespace DemoEmployee.Employees;
public class Employee:Person, IComparable<Employee>
{
//    //field 
//    private int _id;
//    private string _name;
//    private DateTime _dob;

//    //properties
//    public int Id
//    {
//        get { return _id; }
//        set { _id = value; }
//    }
//    public string Name
//    {
//        get => _name;
//        set => _name = value;
//    }
//    public DateTime Dob
//    {
//        get => _dob;
//        set => _dob = value;
//    }
    public string Address { get; set; }
    public double RateSalary { get;set; }
    public int Manday { get;set; }
    //constructors
    public Employee()
    {
    }

    public Employee(int id, string name, DateTime dob,
        string address, double rateSalary, int manday)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Address = address;
        RateSalary = rateSalary;
        Manday = manday;
    }
    //methods
    private double _calcSalary() { return RateSalary * Manday; }

    public override double getSalary()
    {
       return this.Manday * this.RateSalary;
    }

    public void Print() => Console.WriteLine("Print a Employee");

    public override string Display()
    => base.Display() + $" Salary: {getSalary()}";

    public override string? ToString()
    => base.ToString() + $" Salary: {getSalary()}";

    public int CompareTo(Employee? s)
    {
        return (int)(  s._calcSalary()- this._calcSalary());
    }
}