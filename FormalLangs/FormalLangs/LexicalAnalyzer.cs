using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalLangs
{
    public static class LexicalAnalyzer
    {
        public static List<KeyValuePair<string, string>> Tokenizing(List<LexemeClass> lexemeClasses, string text)
        {
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();

            int index = 0;
            while(index < text.Length)
            {
                string currentLexeme = String.Empty;
                int currentPriority = 0;
                int maxLength = 0;

                foreach(LexemeClass lexemeClass in lexemeClasses)
                {
                    KeyValuePair<bool, int> temp = lexemeClass.Machine.MaxString(text, index);
                    if(temp.Key)
                    {
                        if(maxLength < temp.Value)
                        {
                            currentLexeme = lexemeClass.Name;
                            currentPriority = lexemeClass.Priority;
                            maxLength = temp.Value;
                        }
                        else if (maxLength == temp.Value && currentPriority < lexemeClass.Priority)
                        {
                            currentLexeme = lexemeClass.Name;
                            currentPriority = lexemeClass.Priority;
                            maxLength = temp.Value;
                        }
                    }
                }

                if(maxLength > 0)
                {
                    result.Add(new KeyValuePair<string, string>(currentLexeme, text.Substring(index, maxLength)));
                    index += maxLength;
                }
                else
                {
                    result.Add(new KeyValuePair<string, string>("ERROR", index.ToString()));
                    index++;
                }
            }

            return result;
        }
    }
}
