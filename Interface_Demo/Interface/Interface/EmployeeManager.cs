﻿using System;
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

public class EmployeeManager:IPerson
{
    //co 1 mang chua cac employee
    private Person[] _emp;
    private int _size;
    //not understand
    public EmployeeManager()
    {
        this._emp=new Employee[NumberEmployee.NumberOfEmployee];
        this._size= default(int);// default int = 7;
    }
    public EmployeeManager(Person[] emp)
    {
        _emp = emp;
        _size=emp.Length;
    }
    // not understand
    public Person[] employee => _emp;

    public void Add(Person e)
    {
        // check xem array co bị đầy hay ko
        if (this._size >= _emp.Length)
        {
            // nối mảng dài ra
            Person[] newEmp = new Employee[this._size * 2];
            // coppy mảng emp qua mảng newEmp
            Array.Copy(this._emp, 0, newEmp,0,this._size);
            this._emp = newEmp;
        }
        this._emp[this._size++]=e;

    }
    public void Update(Person e)
    {

    }
    public void Delete(Person e)
    {

    }
    

    public Person[] GetAll()
    {
        return this._emp;
    }

    public void Display()
    {
        foreach(Person p in this._emp)
        {
            Console.WriteLine(p);
        }
    }

    public Person GetbyId(int id)
    {
        throw new NotImplementedException();
    }
}