using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalLangs
{
    class Program
    {
        static void Main(string[] args)
        {
            FiniteStateMachine test = new FiniteStateMachine("input1.json");

            Console.WriteLine(test.MaxString("hvvvhhvvhv", 1));
        }
    }
}
