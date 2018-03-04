using System;
using System.Collections.Generic;

namespace _1._3_URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"'Mr John Smith    ' -> URLify -> {ConvertToURL("Mr John Smith    ".ToCharArray(), 13)}");
            Console.WriteLine($"'Mr John  ' -> URLify -> {ConvertToURL("Mr John  ".ToCharArray(), 7)}");
            Console.WriteLine($"'AB CDE FG H      ' -> URLify -> {ConvertToURL("AB CDE FG H      ".ToCharArray(), 11)}");

            Console.ReadLine();
        }

        private static string ConvertToURL(char[] str, int trueLength)
        {
            List<int> SpaceIndices = new List<int>();

            for (int i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    SpaceIndices.Add(i);
                }
            }

            SpaceIndices.Add(trueLength);

            for (int i = SpaceIndices.Count - 1; i >=  1; i--)
            {
                int ShiftFactor = 2 * i;
                int LowerIndex = SpaceIndices[i - 1] + 1;
                int UpperIndex = SpaceIndices[i] - 1;

                for (int j = UpperIndex; j >= LowerIndex; j--)
                {
                    str[j + ShiftFactor] = str[j];
                }

                str[LowerIndex + ShiftFactor - 1] = '0';
                str[LowerIndex + ShiftFactor - 2] = '2';
                str[LowerIndex + ShiftFactor - 3] = '%';
            }


            return string.Concat(str);
        }
    }
}
