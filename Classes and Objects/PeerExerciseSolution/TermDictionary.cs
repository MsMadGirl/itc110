using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPeerExcercise
{
    public class TermDictionary
    {
        private List words;

        public TermDictionary()
        {
            words = new List();
        }

        public void AddWord(Word w)
        {
            words.Add(w);
        }

        public string GetDefinition(string wordTerm)
        {
            string def = null;
            foreach(Word w in words)
            {
                if(w.Term.Equals(wordTerm))
                {
                    def = w.Definition;
                    break;
                }
            }

            return def;
        }

    }
}