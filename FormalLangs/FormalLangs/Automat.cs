using System.Collections.Generic;

namespace FormalLangs
{
    public class Automat
    {
        public List<string> Alphabet;
        public List<string> States;
        public List<string> InitStates;
        public List<string> EndStates;
        public List<Function> Function;
    }

    public class Function
    {
        public string letter;
        public Dictionary<string, List<string>> function;
    }
}