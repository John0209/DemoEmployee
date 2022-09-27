using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEmployee.Number;
using DemoEmployee.Employees;
using DemoEmployee.Per;
using DemoEmployee.Repository;

namespace DemoEmployee.Manager;
using static System.Console;

public class EmployeeManager: IPerson<Employee>
{
    //co 1 mang chua cac employee
    private List<Employee> _emp;
    private int _size;
    //not understand
    public EmployeeManager()
    {
        this._emp=new List<Employee>();
        this._size= default(int);// default int = 7;
    }
    public EmployeeManager(List<Employee> emp)
    {
        _emp = emp;
    }
    // not understand
    public List<Employee> employee => _emp;

    public void Add(Employee e)
    {
        this._emp.Add(e);
    }
    public void Update(Employee e)
    {

    }
    public void Delete(Employee e)
    {

    }
    

    public List<Employee> GetAll()
    {
        return this._emp;
    }

    

    public Employee GetbyId(int id)
    {
        throw new NotImplementedException();
    }
}
