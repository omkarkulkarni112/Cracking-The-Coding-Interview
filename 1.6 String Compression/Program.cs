using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Compressed version of string 'aabcccccaaa' is {CompressString("aabcccccaaa")}");
            Console.WriteLine($"Compressed version of string 'aaaaac' is {CompressString("aaaaac")}");
            Console.WriteLine($"Compressed version of string 'aabb' is {CompressString("aabb")}");
            Console.WriteLine($"Compressed version of string 'aaa' is {CompressString("aaa")}");
            Console.WriteLine($"Compressed version of string 'a' is {CompressString("a")}");
            Console.WriteLine($"Compressed version of string 'aa' is {CompressString("aa")}");
            Console.WriteLine($"Compressed version of string 'aaabbbcd' is {CompressString("aaabbbcd")}");
            Console.WriteLine($"Compressed version of string 'aaabbbcdd' is {CompressString("aaabbbcdd")}");

            Console.ReadLine();
        }

        private static string CompressString(string str)
        {
            StringBuilder result = new StringBuilder();

            int pointer = 0;

            while (pointer < str.Length)
            {
                int startIndex = pointer;

                while (pointer < str.Length &&
                    str[startIndex] == str[pointer])
                {
                    pointer++;
                }

                if (result.Length <= str.Length - 3)
                {
                    result.Append(str[startIndex]);
                    result.Append(pointer - startIndex);
                }
                else
                {
                    return str;
                }
            }

            return result.ToString();
        }
    }
}
