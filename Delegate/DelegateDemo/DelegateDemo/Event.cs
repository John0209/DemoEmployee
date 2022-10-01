using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate void Mydelegate(string name);
     class Event
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.change += St_change;
            st.Name = "Huy";
            Console.WriteLine("Name: "+st.Name);
            st.Name = "Linh";
            Console.WriteLine("New Name: " + st.Name);
            Console.ReadLine();
        }

        private static void St_change(string name)
        {
            Console.WriteLine("Change: "+name);
        }
    }
    class student
    {
        public event Mydelegate change;
        private string _name;
        public string Name {
            get => _name;
            set
            {
                _name = value;
                if(change != null)
                {
                    change(Name);
                }
            }
        }

    }
}
