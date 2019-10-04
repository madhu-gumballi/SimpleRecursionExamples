using System;
namespace SimpleRecursionExamples
{
    public class Pow
    {
        public int PowRecursion(int x, int y)
        {
            // Base Case
            if(y == 1)
            {
                // x is used for computation while y is used to track recursive call till base condition is meet
                return x;
            }
            // Recursive Call
            return x * PowRecursion(x, y - 1);
        }
    }
}
