using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int N) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int minPerimeter = Int32.MaxValue;
    int smallerSide = 1;
    while (smallerSide * smallerSide < N){
        if (N % smallerSide == 0){
            int perimeter = 2 * (smallerSide + (N/smallerSide));
            minPerimeter = Math.Min(minPerimeter, perimeter);
        }
        smallerSide++;
    }
    // if we have a square, try it
    if (smallerSide * smallerSide == N){
        int perimeter = 4 * smallerSide;
        minPerimeter = Math.Min(minPerimeter, perimeter);
    }
    return minPerimeter;
}
int nTest = 30;
Console.WriteLine("area " + nTest + " has minimum perimeter: " + solution(nTest));
