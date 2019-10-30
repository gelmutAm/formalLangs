using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormalLangs
{
    public static class FileManager
    {
        public static string Read(string fileName)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
            {
                result.Append(sr.ReadToEnd());
            }

            return result.ToString();
        }

        public static List<string> ReadAllLines(string fileName)
        {
            List<string> temp = new List<string>();

            using (StreamReader file = new StreamReader(fileName))
            {                
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    temp.Add(line);
                }
            }

            return temp;
        }

        public static void Write(string fileName, string information)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.Default))
            {
                sw.WriteLine(information);
            }
        }
    }
}
