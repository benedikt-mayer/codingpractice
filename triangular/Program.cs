using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int[] test1 = {10, 2, 5, 1, 8, 20};
int[] test2 = {10, 50, 5, 1};

// O(n^3) complexity
int solution(int[] A)
{
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    for (int p = 0; p < A.Length; p++)
    {
        for (int q = p + 1; q < A.Length; q++)
        {
            for (int r = q + 1; r < A.Length; r++)
            {
                if (A[p] + A[q] > A[r] && A[q] + A[r] > A[p] && A[r] + A[p] > A[q])
                {
                    return 1;
                }
            }
        }
    }
    return 0;
}

// due to sorting, O(n log(n)) complexity 
int solution2(int[] A){
    if (A.Length < 3){
        return 0;
    }
    List<long> sortedA = A.Select(element => (long) element).ToList();
    sortedA.Sort();
    long[] sortedAArray = sortedA.ToArray();
    for(int index = 0; index < sortedAArray.Length-2; index++){
        if (sortedAArray[index] >= 0){
            // since we have sorted the array:
            // sortedAArray[index+1] + sortedAArray[index+2] > sortedAArray[index] will always be true and
            // sortedAArray[index] + sortedAArray[index+2] > sortedAArray[index+1] will always be true.
            // thus, we only have to check this.
            // Also, there indices only need to be different, so the mangling of indices because of sorting doesn't matter.
            if (sortedAArray[index] + sortedAArray[index+1] > sortedAArray[index+2]){
                return 1;
            }
        }
    }
    return 0;
}

Console.WriteLine("solution1 test1 correct: " + (solution(test1) == 1));
Console.WriteLine("solution1 test2 correct: " + (solution(test2) == 0));
Console.WriteLine("solution2 test1 correct: " + (solution2(test1) == 1));
Console.WriteLine("solution2 test2 correct: " + (solution2(test2) == 0));