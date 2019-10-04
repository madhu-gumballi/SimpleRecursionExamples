using System;
namespace SimpleRecursionExamples
{
    public class AddSequence
    {
        public int AddSequenceTill(int x)
        {
            // Base Case
            if(x == 1)
            {
                // We use a single parameter x for both computation as well as to track recursive calls till base condition
                return x;
            }
            // Recursive Call
            return x + AddSequenceTill(x - 1);
        }
    }
}
