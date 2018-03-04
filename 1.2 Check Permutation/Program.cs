using System;
using System.Collections.Generic;

namespace _1._2_Check_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is 'a' permutation of 'b' = {IsPermutation("a", "b")}");
            Console.WriteLine($"Is 'a' permutation of 'aa' = {IsPermutation("a", "aa")}");
            Console.WriteLine($"Is 'abcd' permutation of 'bcda' = {IsPermutation("abcd", "bcda")}");
            Console.WriteLine($"Is 'ababab' permutation of 'aaabbb' = {IsPermutation("ababab", "aaabbb")}");
            Console.WriteLine($"Is 'ababab' permutation of 'bbbaaa' = {IsPermutation("ababab", "bbbaaa")}");
            Console.WriteLine($"Is 'lmnopqrst' permutation of 'mlontsqr' = {IsPermutation("lmnopqrst", "mlontsqr")}");
            Console.WriteLine($"Is 'lmnopqrst' permutation of 'mlpontsqr' = {IsPermutation("lmnopqrst", "mlpontsqr")}");

            Console.WriteLine("Enter input string 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter input string 2:");
            string input2 = Console.ReadLine();

            Console.WriteLine($"Is '{input1}' permutation of '{input2}' = {IsPermutation(input1, input2)}");
            Console.ReadLine();
        }

        private static bool IsPermutation(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }

            Dictionary<char, int> charCountTracker = new Dictionary<char, int>();

            foreach (char c in input1)
            {
                if (charCountTracker.ContainsKey(c))
                {
                    charCountTracker[c]++;
                }
                else
                {
                    charCountTracker.Add(c, 1);
                }
            }

            foreach (char c in input2)
            {
                if (charCountTracker.ContainsKey(c) && charCountTracker[c] > 0)
                {
                    charCountTracker[c]--;
                }
                else
                {
                    return false;
                }
            }

            return true;

            // NO NEED TO CHECK FOR THE COUNTERS TO BE STILL GREATER THAN 1 
            // SINCE THAT CANT HAPPEN AS WE HAVE EQUALL LENGTH STRINGS
        }
    }
}
