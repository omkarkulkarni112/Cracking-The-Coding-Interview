using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_Palindrome_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is 'Tact coa' permutation of palindrome string? => {IsPermutationOfPalindrome("Tact coa")}");
            Console.WriteLine($"Is 'Ta ct coa' permutation of palindrome string? => {IsPermutationOfPalindrome("Ta ct coa")}");
            Console.WriteLine($"Is '' permutation of palindrome string? => {IsPermutationOfPalindrome("")}");
            Console.WriteLine($"Is 'aaaa' permutation of palindrome string? => {IsPermutationOfPalindrome("aaaa")}");
            Console.WriteLine($"Is 'aaa' permutation of palindrome string? => {IsPermutationOfPalindrome("aaa")}");
            Console.WriteLine($"Is 'abb' permutation of palindrome string? => {IsPermutationOfPalindrome("abb")}");
            Console.WriteLine($"Is 'aabbac' permutation of palindrome string? => {IsPermutationOfPalindrome("aabbac")}");
            Console.WriteLine($"Is 'aaabbbccc' permutation of palindrome string? => {IsPermutationOfPalindrome("aaabbbccc")}");
            Console.WriteLine($"Is 'aaabbb' permutation of palindrome string? => {IsPermutationOfPalindrome("aaabbb")}");

            Console.ReadLine();
        }

        private static bool IsPermutationOfPalindrome(string str)
        {
            str = str.ToLower();
            List<char> charTracker = new List<char>();

            foreach (char c in str)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (charTracker.Contains(c))
                {
                    charTracker.Remove(c);
                }
                else
                {
                    charTracker.Add(c);
                }
            }

            if (charTracker.Count > 1)
            {
                return false;
            }

            return true;
        }
    }
}
