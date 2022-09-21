namespace DemoEmployee.Employees;
public class Employee
{
    //field 
    private int _id;
    private string _name;
    private DateTime _dob;

    //properties
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public DateTime Dob
    {
        get => _dob;
        set => _dob = value;
    }
    public string Address { get;set }
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
    public double GetSalary() { return this._calcSalary(); }

    public override string ToString() =>$"ID: {Id}, Name: {Name},"+
        $"Address: {Address}"+$"Salary: {this._calcSalary()}";
    

}