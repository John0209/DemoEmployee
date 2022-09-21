using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEmployee.Number;
using DemoEmployee.Employees;
namespace DemoEmployee.Manager;
using static System.Console;

public class EmployeeManager
{
    //co 1 mang chua cac employee
    private Employee[] _emp;
    private int _size;
    //not understand
    public EmployeeManager()
    {
        this._emp=new Employee[NumberEmployee.NumberOfEmployee];
        this._size= default(int);// default int = 7;
    }
    public EmployeeManager(Employee[] emp)
    {
        _emp = emp;
        _size=emp.Length;
    }
    // not understand
    public Employee[] employee => _emp;

    public void Add(Employee e)
    {
        // check xem array co bị đầy hay ko
        if (this._size >= _emp.Length)
        {
            // nối mảng dài ra
            Employee[] newEmp = new Employee[this._size * 2];
            // coppy mảng emp qua mảng newEmp
            Array.Copy(this._emp, 0, newEmp,0,this._size);
            this._emp = newEmp;
        }
        this._emp[this._size++]=e;

    }
    public void Update(Employee e)
    {

    }
    public void Delete(Employee e)
    {

    }
    public Employee GetEmployeeById(int id)
    {
        return null;
    }
    public void PrintAllEmployee()
    {
        foreach(Employee e in _emp)
        {
           WriteLine(e);
        }
    }

}
