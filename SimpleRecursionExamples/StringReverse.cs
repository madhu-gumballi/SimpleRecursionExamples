using System;
namespace SimpleRecursionExamples
{
    public class StringReverse
    {
        public static void Main(string[] args)
        {
            StringReverse sr = new StringReverse();
            string input = Console.ReadLine();
            while(input != "q")
            {
                Console.WriteLine(sr.Reverse(input, input.Length));
                input = Console.ReadLine();
            }
        }

        public string Reverse(string s, int length)
        {
            // Base condition 1
            if(s == string.Empty)
            {
                return string.Empty;
            }
            // Base condition 2
            if(s.Length == 1)
            {
                return s;
            }
            // Recursive call with two parameters and accumulation
            return s[length - 1] + Reverse(s.Substring(0, length - 1), length - 1);
        }
    }
}
