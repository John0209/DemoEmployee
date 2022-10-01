using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo.student;

namespace DelegateDemo
{
     class Event_Donet
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.Change += St_Change;
            st.Name = "number 1";
            st.Name = "number 2";
        }

        private static void St_Change(object sender, nameParameter e)
        {
            Console.WriteLine("Change Auto "+e.hala);
        }
    }
    class student{
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnChanege(value);
            }
        }
        private event EventHandler<nameParameter> _change;
        public event EventHandler<nameParameter> Change
        {
            add => _change += value;
            remove => _change += value;
        }
        void OnChanege(string x)
        {
            if (_change != null)
            {
                // _change(this, EventArgs.Empty);
                _change(this, new nameParameter(x));
            }
        }
        public class nameParameter : EventArgs
        {
            public string hala { get; set; }
            public nameParameter(string s)
            {
                hala = s;
            }
        }
    }
}
