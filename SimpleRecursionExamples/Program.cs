using System;

namespace SimpleRecursionExamples
{
    class MainClass
    {
       public static void Main(string[] args)
        {
            /*Multiplication m = new Multiplication();
            int op1 = 5;
            int op2 = 4;
            int product = m.RepeatedAddition(op1, op2);
            Console.WriteLine("Product of {0} and {1} using Recursion: {2}", op1, op2, product);
            Pow p = new Pow();
            int pow = p.PowRecursion(op1, op2);
            Console.WriteLine("{0} to the power of {1} using Recursion: {2}", op1, op2, pow);
            int sequence = 10;
            AddSequence a = new AddSequence(); */
            int[] sequence = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            AddSequence2 a = new AddSequence2();
            int sum = a.AddSequenceTill(sequence);
            Console.WriteLine("Sum of all numbers from 1 to {0} using Recursion: {1}", sequence, sum);
            Console.ReadLine();
        }
    }
}
