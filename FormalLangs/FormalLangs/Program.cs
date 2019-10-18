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
            FiniteStateMachine machine = new FiniteStateMachine("input_double.json");

            string inputString = FileManager.Read("inputString.txt");

            int k = 0;
            while(k < inputString.Length)
            {
                KeyValuePair<bool, int> result = machine.MaxString(inputString, k);

                if(result.Key == true)
                {
                    string outputString = inputString.Substring(k, result.Value);
                    FileManager.Write("output.txt", outputString);
                    Console.WriteLine(outputString);
                    k += result.Value;
                }
                else
                {
                    k++;
                }
            }
        }
    }
}
