using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEmployee.Employees;
using DemoEmployee.Manager;
using DemoEmployee.Per;
namespace Generic.ExtensionsFuctional;

public static class ExtensionFunctional
{
    public static void DisplayPerson(this EmployeeManager e, List<Employee> data)
    {
        foreach (Employee p in data)
        {
            Console.WriteLine(p);
        }
    }
}
