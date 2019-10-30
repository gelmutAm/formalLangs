using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormalLangs
{
    public class LexemeClass
    {
        public string Name { get; set; }

        public FiniteStateMachine Machine { get; set; }
        
        public int Priority { get; set; }

        public LexemeClass() { }

        public LexemeClass(string name, FiniteStateMachine machine, int priority)
        {
            this.Name = name;
            this.Machine = machine;
            this.Priority = priority;
        }

        public LexemeClass(string fileName)
        {
            List<string> temp = FileManager.ReadAllLines(fileName);

            this.Name = temp[0];
            this.Machine = new FiniteStateMachine(temp[1]);
            this.Priority = int.Parse(temp[2]);
        }
    }
}
