using DemoEmployee.Per;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Student;

public class Student:Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }

    public override double getSalary()
    {
        throw new NotImplementedException();
    }
}
