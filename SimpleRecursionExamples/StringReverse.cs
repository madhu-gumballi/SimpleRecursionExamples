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
                Console.WriteLine(sr.Reverse(input));
                input = Console.ReadLine();
            }
        }

        public string Reverse(string s)
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
            // Recursive call with one parameters and accumulation
            return s[s.Length - 1] + Reverse(s.Substring(0, s.Length - 1));
        }
    }
}
