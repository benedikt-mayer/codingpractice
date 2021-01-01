using System;
// you can also use other imports, for example:
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int total = A.Sum();
    int leftSide = 0;
    int minimumDifference = Int32.MaxValue;
    for(int index = 0; index < A.Length - 1; index++){
        int tapeNumber = A[index];
        leftSide += tapeNumber;
        int rightSide = total - leftSide;
        int difference = Math.Abs(leftSide - rightSide);
        minimumDifference = Math.Min(minimumDifference, difference);
    }
    return minimumDifference;
}
int[] testSet = {-1000, 1000};
Console.WriteLine("solution correct: " + (solution(testSet) == 2000));

