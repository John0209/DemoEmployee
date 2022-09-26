using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmployee.Per;

public abstract class Person
{
    private int _id;
    private string _name;
    private DateTime _dob;

    public int Id { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public DateTime Dob { get { return _dob; } set { _dob = value; } }
    public string Address { get; set; }
    public abstract double getSalary();
    public virtual string Display() => $"ID: {Id}, Name: {Name}," +
        $" Dob: {Dob}";

    public override string? ToString()
   => $"Id: {Id},Name: {Name}, Address:{Address}";

    public void Print() => Console.WriteLine("Print a Person");
   

    
}
