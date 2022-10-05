using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo;

 class Anomymous
{
   delegate void HelloD(int i);

    public static void Main(string[] args)
    {
        HelloD dele = delegate (int i) { Console.WriteLine($"Hello {i}"); };
        dele(1);
    }
    static void help(HelloD monkey, int val)
    {
        val += 1;
        monkey(val);
    }
}
