using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            string allPalindrome = "All palindrome words are as follows:\n";
            while (true)
            {
                Console.WriteLine("Please enter a word (enter \"end\" to end the program)");
                string userWord = Console.ReadLine();
                if (userWord != "end")
                {
                    if (IsPalindrome(userWord))
                    {
                        allPalindrome = allPalindrome + userWord + " ";
                        if (IsNumeric(userWord))
                        {
                            Console.WriteLine("The word is a number palindrome.");
                        }
                        else
                        {
                            Console.WriteLine("The word is a character palindrome.");
                        }


                    }
                    else
                    {
                        Console.WriteLine("The word is not a palindrome.");
                    }

                }
                if (userWord == "end")
                {
                    Console.WriteLine(allPalindrome);
                    break;
                }
            }
        }

        public static bool IsPalindrome(string word)
        {
            char[] wordItems = word.ToCharArray();
            /*char[] wordReversedItems = wordItems;
            Array.Reverse(wordReversedItems);
            foreach(char item in wordItems)
            {
                Console.WriteLine(item);
            }*/
            return wordItems.SequenceEqual(wordItems.Reverse());
        }

        public static bool IsNumeric(string text)
        {
            int test;
            return int.TryParse(text, out test);
            Console.ReadLine();
        }
    
    }
}
