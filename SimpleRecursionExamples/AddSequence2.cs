using System;
namespace SimpleRecursionExamples
{
    public class AddSequence2
    {
        // The input parameter to the recursive call here is an integer array as against an integer
        public int AddSequenceTill(int[] a)
        {
            // Base Case
            if (a.Length == 0)
            {
                // Here we use the size of the arry for our base condition
                return 0;
            }
            if(a.Length == 1)
            {
                // At this point, we would have broken down the array to a unit consisting of single element - which is our 2nd base condition
                return a[0];
            }
            // Multiple Recursive calls using divide and conquer
            // Here we decompose the problem into 2 sub-problems of roughly half the size of the original array 
            int mid = a.Length / 2;
            int[] a1 = new int[mid];
            int[] a2 = new int[a.Length - mid];
            Array.Copy(a, 0, a1, 0, mid);
            Array.Copy(a, mid, a2, 0, a.Length - mid);
            return AddSequenceTill(a1) + AddSequenceTill(a2);
        }
    }
}
