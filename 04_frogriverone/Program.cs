using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int X, int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    HashSet<int> relevantLeaves = new HashSet<int>();
    int foundLeaves = 0;
    for(int second = 0; second < A.Length; second++){
        int leaf = A[second];
        if (!relevantLeaves.Contains(leaf) && leaf <= X){
            relevantLeaves.Add(leaf);
            foundLeaves++;
            if (foundLeaves == X){
                return second;
            }
        }
    }
    return -1;
}
int[] testSet = {1, 3, 1, 4, 2, 3, 5, 4};
int testX = 5;
Console.WriteLine("solution is correct: " + (solution(testX, testSet) == 6));
