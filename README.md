## Simple Recursion Examples
- Overview
- Recursion Breakdown
- Examples
   - Multiplication using Repeated Addition
   - X to the power of Y
   - Add all numbers in sequence till X
   - Reverse a string
   

### Overview

[Recursion](https://everything2.com/index.pl?node_id=477013) is a simple and elegant concept in programming, yet many programmers including experienced ones find it hard to wrap their heads around it. Most text book examples start and end with fibonacci series or the factorial examples. This is my attempt to simplify the concept with better examples and also to bring out the various patterns that are employed in recursion.

### Recursion Breakdown
Every recursive solution can be broken down into following components
- [X] One or more **base conditions** that allows the recursive call to terminate
- [X] An **expression** or logic that will help us arrive at the base condition
- [X] One or more Recursive **calls to self**, typically a complex divide and conquer problem can have multiple recursive calls, whereas the ones we have here such as string reversal, repeated addition, etc., have a single recursive call.
- [X] Recursive calls could be embedded within the function or it could be a [tail call](https://en.wikipedia.org/wiki/Tail_call)
- [X] One or more **parameters** passed to the recursive call. The number of parameters depends on the logic you employ to arrive at the solution and also the various base conditions that you may employ. 

### [Multiplication using Repeated Addition](https://github.com/1kautilya1/SimpleRecursionExamples/blob/master/SimpleRecursionExamples/Multiplication.cs)

Inputs: 5, 4

Start building call stack as show below

`= 5 + RepeatedAddition(5, 4 - 1)`

`= 5 + RepeatedAddition(5, 4 - 1) + RepeatedAdditions(5, 3 - 1)`

`= 5 + RepeatedAddition(5, 4 - 1) + RepeatedAdditions(5, 3 - 1) + RepeatedAdditions(5, 2 - 1)`

Now call stack gets unwinded by executing the calls

`= 5 + RepeatedAddition(5, 4 - 1) + RepeatedAdditions(5, 3 - 1) + 5`

`= 5 + RepeatedAddition(5, 4 - 1) + 5 + 5`

`= 5 + 5 + 5 + 5`

`= 20`

Base Condition | Expression | # of Recursive Calls | # of parameters
-------------- | ---------- | ------------------------- | --------------------
y == 1         | return x + RepeatedAddition(x, y - 1); | 1 | 2

### [X to the power of Y](https://github.com/1kautilya1/SimpleRecursionExamples/blob/master/SimpleRecursionExamples/PowRecursion.cs)

Inputs: 5, 4

Start building call stack as show below

`= 5 * PowRecursion(5, 4 - 1)`

`= 5 * PowRecursion(5, 4 - 1) * PowRecursion(5, 3 - 1)`

`= 5 * PowRecursion(5, 4 - 1) * PowRecursion(5, 3 - 1) * PowRecursion(5, 2 - 1)`


Now call stack gets unwinded by executing the calls

`= 5 * PowRecursion(5, 4 - 1) * PowRecursion(5, 3 - 1) + 5`

`= 5 * PowRecursion(5, 4 - 1) * 5 * 5`

`= 5 * 5 * 5 * 5`

`= 625`

Base Condition | Expression | # of Recursive Calls | # of parameters
-------------- | ---------- | ------------------------- | --------------------
y == 1         | return x * PowRecursion(x, y - 1); | 1 | 2


### [Add all numbers in sequence till X](https://github.com/1kautilya1/SimpleRecursionExamples/blob/master/SimpleRecursionExamples/AddSequence.cs)

Input: 5

Start building call stack as show below

`= 5 + AddSequenceTill(5 - 1)`

`= 5 + AddSequenceTill(5 - 1) + AddSequenceTill(4 - 1)`

`= 5 + AddSequenceTill(5 - 1) + AddSequenceTill(4 - 1) + AddSequenceTill(3 - 1)`

`= 5 + AddSequenceTill(5 - 1) + AddSequenceTill(4 - 1) + AddSequenceTill(3 - 1) + AddSequenceTill(2 - 1)`

Now call stack gets unwinded by executing the calls

`= 5 + AddSequenceTill(5 - 1) + AddSequenceTill(4 - 1) + AddSequenceTill(3 - 1) + 1`

`= 5 + AddSequenceTill(5 - 1) + AddSequenceTill(4 - 1) + 2 + 1`

`= 5 + AddSequenceTill(5 - 1) + 3 + 2 + 1`

`= 5 + 4 + 3 + 2 + 1`

`= 15`

Base Condition | Expression | # of Recursive Calls | # of parameters
-------------- | ---------- | ------------------------- | --------------------
x == 1         | return x + AddSequenceTill(x - 1); | 1 | 1

### [Reverse a string](https://github.com/1kautilya1/SimpleRecursionExamples/blob/master/SimpleRecursionExamples/StringReverse.cs)

Input: "Hello"

`= 'o' + Reverse("Hell")`

`= 'o' + Reverse("Hell") + Reverse("Hel")`

`= 'o' + Reverse("Hell") + Reverse("Hel") + Reverse("He")`

`= 'o' + Reverse("Hell") + Reverse("Hel") + Reverse("He") + Reverse("H")`


Now call stack gets unwinded by executing the calls

`= 'o' + 'l' + Reverse("Hel") + Reverse("He") + Reverse("H")`

`= 'o' + 'l' + 'l' + Reverse("He") + Reverse("H")`

`= 'o' + 'l' + 'l' + 'e' + Reverse("H")`

`= 'o' + 'l' + 'l' + 'e' + 'H'`

`= 'olleH'`

Base Conditions | Expression | # of Recursive Calls | # of parameters
-------------- | ---------- | ------------------------- | --------------------
s == string.Empty & s.Length == 1 | return s[s.Length - 1] + Reverse(s.Substring(0, s.Length - 1)); | 1 | 1

