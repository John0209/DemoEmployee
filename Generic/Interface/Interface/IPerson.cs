using DemoEmployee.Per;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmployee.Repository;

public interface IPerson
{
    Person[] GetAll();
    void Display();
    void Add(Person p);
    void Update(Person p);  
    Person GetbyId(int id);
    void Delete(Person p);

}
