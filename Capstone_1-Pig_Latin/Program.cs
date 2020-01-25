using System;
using System.Text;

namespace Capstone_1_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            string userContinue = "y";
            while (userContinue == "y")
            {
                Console.WriteLine("Please enter the word you would like to translate");
                string userInput = Console.ReadLine().ToLower();

                if (StartsWithVowel(userInput))
                {
                    Console.WriteLine(userInput + "way");
                }
                else
                {
                    Console.WriteLine(MakePigLatin(userInput));
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                userContinue = Console.ReadLine().ToLower();
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    userContinue = Console.ReadLine();
                }
            }
        }




        //Accepts a string as input, and for each element in the 'vowels' array, asks if the given string StartsWith a vowel, if so, returns true, else returns false
        public static bool StartsWithVowel(string wordToCheck)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool result = true;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (wordToCheck.StartsWith(vowels[i]))
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
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
