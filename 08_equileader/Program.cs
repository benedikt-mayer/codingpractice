using System;

// you can also use other imports, for example:
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int[] A){
    int dominatorIndex = FindDominator(A);
    Console.WriteLine("dominator index: " + dominatorIndex);
    if (dominatorIndex == -1){
        return 0;
    }
    int dominatorValue = A[dominatorIndex];
    int totalOccurrences = A.Where(value => value == dominatorValue).Count();
    int occurrencesSoFar = 0;
    int equiLeaders = 0;
    Console.WriteLine("total: " + totalOccurrences + " dominator value: " + dominatorValue);
    for(int index = 0; index < A.Length; index++){
        if (A[index] == dominatorValue){
            occurrencesSoFar++;
        }
        if (occurrencesSoFar > ((index+1) / 2)){
            int remainingElements = A.Length - (index+1);
            int remainingOccurrences = totalOccurrences - occurrencesSoFar;
            if (remainingOccurrences > (remainingElements/2)){
                equiLeaders++;
                Console.WriteLine("found equileader");
            }
        }
    }
    return equiLeaders;
}

int FindDominator(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int size = 0;
    int topOfStack = 0;
    foreach(int value in A){
        if (size == 0){
            size++;
            topOfStack = value;
        } else if (topOfStack == value){
            size++;
        } else {
            size--;
        }
    }
    int occurrences = A.Where(value => value == topOfStack).Count();
    if (occurrences > (A.Length / 2)){
        for(int index = 0; index < A.Length; index++){
            if (A[index] == topOfStack){
                return index;
            }
        }
        return -1;
    } else {
        return -1;
    }
}

int[] test1 = {4,3,4,4,4,2};
int test1Results = 2;
Console.WriteLine("dominator? " + FindDominator(test1));
Console.WriteLine("test1 with result " + solution(test1) + " passed: " + (test1Results == solution(test1)));
