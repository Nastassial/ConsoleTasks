using System;

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
            int number, optionNum;

            Console.WriteLine("Choose the option:\n"
                            + "1 - Check the words for anagrams\n"
                            + "2 - Check the word for palindrome\n"
                            + "3 - Get prime numbers\n"
                            + "4 - Exit\n"
                            );

            while (true)
            {
                optionNum = Convert.ToInt32(Console.ReadLine());

                if (optionNum == 4) break;

                switch (optionNum)
                {
                    case 1:
                        Console.Write("Enter the words for checking for anagrams:\n");

                        text = Console.ReadLine().ToLower().Trim();

                        Console.Write(CheckForAnagrams(text.Split(' ')));

                        break;

                    case 2:
                        Console.Write("Enter the words for checking for palindrome:\n");

                        text = Console.ReadLine().ToLower().Trim();

                        Console.Write(CheckForPalindrome(text));

                        break;
                    
                    case 3:
                        Console.Write("Enter the number:\n");

                        number = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.Write(GetPrimeList(number) + "\n");

                        break;
                }
            }
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

        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                    return false;
            }

            return true;
        }
        
        static string GetPrimeList(int number)
        {
            string primeList = "";

            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                    primeList += i + ", ";
            }

            return primeList.TrimEnd(new char[] { ',', ' ' });
        }
    }
}
