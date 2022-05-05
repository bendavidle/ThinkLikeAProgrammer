using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkLikeAProgrammer
{
    internal class WordCounter
    {
        internal static void Start()
        {
            Console.Write("Write something: ");
            string sentence = Console.ReadLine();
            int words = CountWords(sentence);
            int vowels = CountVowels(sentence);
            int longest = LongestWordLength(sentence);
            Console.WriteLine($"\"{sentence}\" has {words} words, {vowels} vowels and the longest word is {longest} characters long.");
        }

        private static int CountWords(string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        private static int CountVowels(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        private static int LongestWordLength(string text)
        {
            string largest = "";
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > largest.Length)
                {
                    largest = word;
                }
            }
            return largest.Length;
        }

        private static bool IsVowel(char c)
        {
            char[] vowels = new char[] { 'a', 'e', 'u', 'i', 'o' };
            return vowels.Contains(c);
        }
    }

    
}
