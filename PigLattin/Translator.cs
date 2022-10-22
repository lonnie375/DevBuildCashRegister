using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLattin
{
    public class Translator
    {
        //Returns true if it's a vowel, false if it's a consonant 
        public static bool IsVowel(char ch)
        {
            if (ch == 'a' || ch == 'i'  || ch == 'e' || ch == 'o' || ch == 'u')
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

        public static bool StartsWIthVowel(string str)
        {
            bool result = IsVowel(str[0]);
            return result;
        }

        public static int NumberOfCons(string word)
        {
            int index = 0; 

            while (index < word.Length && IsVowel(word[index]) == false){

                index++;
            }

            return index;
        }

        //Two methods for PigLatinizing a word 
        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }

        public static string PigLatinCons(string word)
        {
            int cons = NumberOfCons(word);
            string start = word.Substring(0, cons);
            string newWord = word.Remove(0, start.Length);

            return newWord + start + "ay"; 
        }

        public static string PigLatinize(string word)
        {
            if (StartsWIthVowel(word))
            {
                return PigLatinVowels(word); 
            }
            else
            {
                return PigLatinCons(word);
            }
        }


    }
}
