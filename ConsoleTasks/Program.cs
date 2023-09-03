using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for reading and writing russian symbols
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string text;

            Console.Write("Enter the words for checking for anagrams:\n");

            text = Console.ReadLine().ToLower().Trim();

            Console.Write(CheckForAnagrams(text.Split(' ')));

            Console.Write("Enter the words for checking for palindrome:\n");

            text = Console.ReadLine().ToLower().Trim();

            Console.Write(CheckForPalindrome(text));

            Console.ReadKey();
        }

        static string CheckForAnagrams(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (SortStringLetters(words[i]) != SortStringLetters(words[++i]))
                {
                    return "Words are not anagrams\n";
                }
            }

            return "Words are anagrams\n";
        }

        static string SortStringLetters(string str)
        {
            char[] lettersArr;

            lettersArr = str.ToCharArray();

            Array.Sort(lettersArr);

            return new String(lettersArr);
        }

        static string CheckForPalindrome(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    return "Word is not palindrome\n";
                }
            }

            return "Word is palindrome\n";
        }
    }
}
