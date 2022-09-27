using DemoEmployee.Employees;
using DemoEmployee.Per;
using Generic.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmployee.Repository;

public interface IPerson<P> where P : Employee, new()
{
    List<P> GetAll();
    void Add(P p);
    void Update(P p);  
   P GetbyId(int id);
    void Delete(P p);

}
