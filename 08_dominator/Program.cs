using System;

// you can also use other imports, for example:
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int solution(int[] A) {
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
    int occurences = A.Where(value => value == topOfStack).Count();
    if (occurences > (A.Length / 2)){
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

int[] test1 = {3,4,3,2,3,-1,3,3};
int[] test1Results = {0,2,4,6,7};
Console.WriteLine("test1 passed: " + test1Results.Contains(solution(test1)));
