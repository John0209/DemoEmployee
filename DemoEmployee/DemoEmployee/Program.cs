using DemoEmployee.Employees;
using DemoEmployee.Manager;
namespace DemoEmployee.program;
public class Program
{
    public static void Main()
    {
        Employee[] employee = new Employee[]
        {
            new Employee(1,"Hùng",new DateTime(1989,12,2),"HCM",3500,30),
            new Employee(2,"Hào",new DateTime(1929,10,11),"HCM",3500,12),
            new Employee(3,"Chiến",new DateTime(1999,1,27),"HCM",3500,22),
        };
        EmployeeManager empManager= new EmployeeManager(employee);
        //Add
        Employee e = new Employee();
        e.Id = 4;
        e.Name = "Huy";
        e.Manday = 10;
        e.RateSalary = 3500;
        e.Address = "HN";
        e.Dob = new DateTime(2000, 2, 18);
        empManager.Add(e);
        //print all
        empManager.PrintAllEmployee();
        Console.ReadKey();
    }
}
