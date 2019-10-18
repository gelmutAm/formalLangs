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

        public static void Write(string fileName, string information)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.Default))
            {
                sw.WriteLine(information);
            }
        }
    }
}
