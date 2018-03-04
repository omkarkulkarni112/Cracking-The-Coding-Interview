using System;

namespace _1._5_One_Away
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is 'pale' one away from 'ple' => {IsOneAway("pale", "ple")}");
            Console.WriteLine($"Is 'pales' one away from 'pale' => {IsOneAway("pales", "pale")}");
            Console.WriteLine($"Is 'p les' one away from 'pale' => {IsOneAway("p les", "pale")}");
            Console.WriteLine($"Is 'p le' one away from 'pale' => {IsOneAway("p le", "pale")}");
            Console.WriteLine($"Is 'pale' one away from 'bake' => {IsOneAway("pale", "bake")}");
            Console.WriteLine($"Is 'pale' one away from 'pale' => {IsOneAway("pale", "pale")}");
            Console.WriteLine($"Is 'pale' one away from 'bale' => {IsOneAway("pale", "bale")}");
            Console.WriteLine($"Is 'a' one away from '' => {IsOneAway("a", "")}");
            Console.WriteLine($"Is 'a' one away from ' ' => {IsOneAway("a", " ")}");

            Console.ReadLine();
        }

        private static bool IsOneAway(string str1, string str2)
        {
            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            int diffs = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        if (diffs == 1)
                        {
                            return false;
                        }
                        diffs++;
                    }
                }

                return true;
            }

            else if (str1.Length > str2.Length)
            {
                string temp = str2;
                str2 = str1;
                str1 = temp;

                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return str1.Substring(i).Equals(str2.Substring(i+1));
                    }
                }

                return true;
            }

            return false;
        }
    }
}
