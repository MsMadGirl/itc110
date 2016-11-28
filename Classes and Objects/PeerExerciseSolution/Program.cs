using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPeerExcercise
{
    class Program
    {
        TermDictionary td = new TermDictionary();
        static void Main(string[] args)
        {
            Program p = new ClassPeerExcercise.Program();
            Word w1 = new Word();
            w1.Term = "shirt";
            w1.Definition = "garmet with sleeves";
            p.td.AddWord(w1);

            Word w2 = new Word();
            w2.Term = "Book";
            w2.Definition = "covers containing pages";
            p.td.AddWord(w2);

            Word w3 = new Word();
            w3.Term = "pencil";
            w3.Definition = "writing utensil";
            p.td.AddWord(w3);

            Console.WriteLine("Enter a word to get Definition");
            string searchWord = Console.ReadLine();

            string def = p.td.GetDefinition(searchWord);

            if(def != null)
            {
                Console.WriteLine(def);
            }
            else
            {
                Console.WriteLine("Not in dictionary");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}