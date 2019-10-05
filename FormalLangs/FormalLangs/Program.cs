using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FormalLangs
{
    class Program
    {
        static void Main(string[] args)
        {
//            FiniteStateMachine test = new FiniteStateMachine("input.txt");
//
//            FiniteStateMachine test1 = test;

            using (StreamReader file = new StreamReader("/Users/ASMANandNASTYA/Desktop/formalLangs/inputFiles/input.json"))
            {
                string json = file.ReadToEnd().Trim();
                Automat aut = JsonConvert.DeserializeObject<Automat>(json);
                foreach (var str in aut.Function[0].function["2"])
                {
                    Console.WriteLine(str);

                }
                
            }
        }
    }
}
