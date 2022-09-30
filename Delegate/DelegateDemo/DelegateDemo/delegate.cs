using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo;

class Demo
{
    delegate string MyDelegate(string s);
    public static void Main(string[] args)
    {
        MyDelegate john = new MyDelegate(myFun);
        MyDelegate jinx = new MyDelegate(myFoam);
        MyDelegate multicast= john+jinx;
        string s = "Welcome";
        //delegate 1 function
        Console.WriteLine("---delegate 1 function---");
        john(s);
        Console.WriteLine("---delegate 2 function---");
        multicast(s);
        Console.WriteLine("---delegate - function---");
        multicast -= john;
        multicast(s);
        Console.WriteLine("**************");
        myName(jinx);
        Console.ReadLine();
    }
    static void myName(MyDelegate print)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        print(name);
    }
    static string myFun(string s)
    {
        string x = s;
        Console.WriteLine("Hello 500 anh em  " +x);
        
        return x;
    }
    static string myFoam(string s)
    {
        string x = s;
        Console.WriteLine("Hello CC  " + x);

        return x;
    }
}
