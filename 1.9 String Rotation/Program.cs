using System;

namespace _1._9_String_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"'waterbottle' is rotation of 'erbottlewat' => {IsRotationOf("waterbottle", "erbottlewat")}");
            Console.WriteLine($"'waterbottle' is rotation of 'erbottletwa' => {IsRotationOf("waterbottle", "erbottletwa")}");

            Console.ReadLine();
        }

        private static bool IsRotationOf(string str1, string str2)
        {
            return (str2 + str2).IndexOf(str1) >= 0;
        }
    }
}
