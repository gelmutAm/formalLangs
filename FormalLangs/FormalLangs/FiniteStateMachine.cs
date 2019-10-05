using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormalLangs
{
    public class FiniteStateMachine
    {
        private List<string> alphabet;
        private List<string> states;
        private List<string> initialStates;
        private List<List<List<string>>> stateTransitionFunction;
        private List<string> finalStates;

        public FiniteStateMachine() { }

        public FiniteStateMachine(List<string> alphabet, List<string> states, List<string> initialStates, 
            List<List<List<string>>> stateTransitionFunction, List<string> finalStates)
        {
            this.alphabet = alphabet;
            this.states = states;
            this.initialStates = initialStates;
            this.stateTransitionFunction = stateTransitionFunction;
            this.finalStates = finalStates;
        }

        public FiniteStateMachine(string fileName)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                List<List<string>> storage = new List<List<string>>();
                List<List<List<string>>> tempTransitionFunction = new List<List<List<string>>>();

                int lineCount = 0;
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    if (lineCount < 4)
                    {
                        List<string> temp = line.Split(' ').ToList();
                        storage.Add(temp);
                    }
                    else
                    {
                        StringBuilder temp = new StringBuilder(line);
                        while (temp.Length > 0)
                        {
                            int lastIndex = temp.ToString().IndexOf('}');
                            List<string> values = temp
                                .ToString()
                                .Substring(1, lastIndex - 1)
                                .Split(' ')
                                .ToList();
                            List<List<string>> tempMatrix = new List<List<string>>();
                            tempMatrix.Add(values);
                            tempTransitionFunction.Add(tempMatrix);
                            temp.Remove(0, lastIndex + 1);
                        }
                    }

                    lineCount++;
                }

                this.alphabet = storage[0];
                this.states = storage[1];
                this.initialStates = storage[2];
                this.finalStates = storage[3];
                this.stateTransitionFunction = tempTransitionFunction;
            }
        }

        public List<string> Alphabet { get; set; }

        public List<string> States { get; set; }

        public List<string> InitialStates { get; set; }

        public List<List<string>> StateTransitionFunction { get; set; }

        public List<string> FinalStates { get; set; }
    }
}
