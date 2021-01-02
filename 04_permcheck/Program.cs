using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    HashSet<int> permutationElements = new HashSet<int>();
    int uniqueOccurences = 0;
    int max = 0;
    int min = Int32.MaxValue;
    foreach(int element in A){
        if (element > 100000){
            return 0;
        }
        if (permutationElements.Contains(element)){
            return 0;
        } else{
            permutationElements.Add(element);
            min = Math.Min(min, element);
            max = Math.Max(max, element);
        }
    }
    if (min != 1 || max != A.Length){
        return 0;
    }
    if (permutationElements.Count == A.Length){
        return 1;
    } else{
        return 0;
    }
}

int[] testSetTrue = {1,2,4,3};
int[] testSetFalse = {2,3,4};

Console.WriteLine("solution is correct for testSetTrue: " + (solution(testSetTrue) == 1));
Console.WriteLine("solution is correct for testSetFalse: " + (solution(testSetFalse) == 0));
