using System;
namespace SimpleRecursionExamples
{
    public class Multiplication
    {
        public int RepeatedAddition(int x, int y)
        {
            // Base Case
            if (y == 1)
            {
                // x is used for computation while y is used to track recursive call till base condition is meet
                return x;
            }
            // Recursive Call
            return x + RepeatedAddition(x, y - 1);
        }
    }
}
