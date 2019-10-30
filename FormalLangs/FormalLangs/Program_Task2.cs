using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalLangs
{
    public class Program_Task2
    {
        static void Main(string[] args)
        {
            LexemeClass id = new LexemeClass("ID.txt");
            LexemeClass kw = new LexemeClass("KW.txt");
            List<LexemeClass> lexemeClasses = new List<LexemeClass>();
            lexemeClasses.Add(id);
            lexemeClasses.Add(kw);

            List<KeyValuePair<string, string>> result = LexicalAnalyzer.Tokenizing(lexemeClasses, "while");

            foreach(KeyValuePair<string, string> res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
