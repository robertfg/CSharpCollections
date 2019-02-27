using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))
            {
                int count = WordCount[word];
                WordCount[word] = count + 1;
            }
            else
            {
                WordCount.Add(word, 1);
            }
        }

        public Dictionary<string, int> WordsWithCountGreaterThan(int count)
        {
            Dictionary<string, int> localDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> wc in WordCount)
            {
                if (wc.Value > count)
                {
                    localDictionary.Add(wc.Key, wc.Value);
                }
            }
            return localDictionary;
        }
    }
}
