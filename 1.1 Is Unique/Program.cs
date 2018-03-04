using System;
using System.Collections.Generic;

namespace _1._1_Is_Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is string '' having unique characters = {AreAllCharactersUnique("")}");
            Console.WriteLine($"Is string '\" \"' having unique characters = {AreAllCharactersUnique(" ")}");
            Console.WriteLine($"Is string 'a' having unique characters = {AreAllCharactersUnique("a")}");
            Console.WriteLine($"Is string 'ab' having unique characters = {AreAllCharactersUnique("ab")}");
            Console.WriteLine($"Is string 'aab' having unique characters = {AreAllCharactersUnique("aab")}");
            Console.WriteLine($"Is string 'ab b' having unique characters = {AreAllCharactersUnique("ab b")}");
            Console.WriteLine($"Is string 'abcdef gfhr' having unique characters = {AreAllCharactersUnique("abcdef gfhr")}");
            Console.WriteLine($"Is string 'abcdef ghr' having unique characters = {AreAllCharactersUnique("abcdef ghr")}");

            Console.WriteLine("Enter string to be checked for having all unique characters:");
            string input = Console.ReadLine();

            Console.WriteLine($"Is string '{input}' having unique characters = {AreAllCharactersUnique(input)}");

            Console.ReadLine();
        }

        private static bool AreAllCharactersUnique(string input)
        {
            HashSet<char> charsInString = new HashSet<char>();

            foreach (char c in input)
            {
                if (charsInString.Contains(c))
                {
                    return false;
                }

                charsInString.Add(c);
            }

            return true;
        }
    }
}
