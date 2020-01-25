using System;
using System.Text;

namespace Capstone_1_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Word please!:");
            string userWord = Console.ReadLine();

            string translatedInput = "";
            for (int i = 0; i < vowels.Length; i++)
            {
                if (userWord.StartsWith(vowels[i]))
                {
                    translatedInput = (userWord + "way");
                    //Console.WriteLine(userWord + "way");
                }
                else
                {
                    translatedInput = MakePigLatin(userWord);
                    //Console.WriteLine(translatedInput);
                }
            }
            Console.WriteLine(translatedInput);

        }
        public static string MakePigLatin(string wordToTranslate)
        {
            string startOfWord;
            string restOfWord;
            string completeWord = "";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < wordToTranslate.Length; i++)
            {
                //looks at word, returns the index of the first vowel
                int vowelPosition = wordToTranslate.IndexOfAny(vowels);
                //looks at first vowel position and word length to create a new string, minus everything before the first vowel
                //e.g. "strength".Substring(vowelPosition (3), ("strength".Length(8) - vowelPosition(3) = (5)) = "ength" (5 characters)  
                restOfWord = wordToTranslate.Substring(vowelPosition, (wordToTranslate.Length - vowelPosition));
                //starts at begining of word (0), and goes until first vowelPosition, returns a string
                //e.g. "strength" => "str"
                startOfWord = wordToTranslate.Substring(0, vowelPosition);
                //recombines substrings, and adds "way", outputing pig latin
                //e.g. "ength" + "str" + "way" = "engthstray
                completeWord = (restOfWord + startOfWord + "ay");
            }
            return completeWord;
        }
        }
    }

