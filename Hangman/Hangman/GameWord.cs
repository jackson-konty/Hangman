using System;
using System.Collections;
using System.Linq;
namespace Hangman
{
    class GameWord
    {
        public string word { get; set;}
        public string definition { get; set;}
        public string context { get; set;}
        public GameWord(string word, string definition, string context)
        {
            this.word = word;
            this.definition = definition;
            this.context = context;}
        public string GetWordLower() {
            return word.ToLower();}
        public string GetBlankContext(Hashtable filled) {
            string[] spaceDel = context.Split(' ');
            string newContext = "";
            foreach (string word in spaceDel) {
                if (StringEquals(word.ToLower())) {
                    newContext += GetBlanks(filled);
                    newContext += ' ';
                }
                else{
                    newContext += word;
                    newContext += " ";
                }
            }
            return newContext;
        }
        public bool StringEquals(string oWord) {
            return word.ToLower().Equals(oWord.ToLower());
        }
        public bool ContainsLetter(char ch) {
            return word.Contains(ch);
        }
        public string GetBlanks(Hashtable filled) {
            string blanks = "";
            for (int i = 0; i < word.Length; i++)
            {
                
                if (filled.ContainsKey(i))
                {
                    blanks += filled[i]+" ";
                }
                else{
                    blanks += "_ ";
                }
            }
            return blanks;
        }
        public int Size() {
            return word.Length;
        }
    }

}
