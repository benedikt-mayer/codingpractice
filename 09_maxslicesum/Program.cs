using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int maxEnding = 0;
    int maxSlice = 0;
    if (A.Max() < 0){
        return A.Max();
    }
    foreach(int element in A){
        maxEnding = Math.Max(0, maxEnding + element);
        maxSlice = Math.Max(maxSlice, maxEnding);
    }
    return maxSlice;
}