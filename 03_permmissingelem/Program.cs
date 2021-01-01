using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility.
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int currentNumber = 1;
    HashSet<int> hashedA = new HashSet<int>(A);
    while(currentNumber < A.Length+2){
        if (hashedA.Contains(currentNumber)){
            currentNumber++;
        } else{
            break;
        }
    }
    return currentNumber;
}

int[] testSet = {2,3,1,5};
int result = solution(testSet);
Console.WriteLine("testset returns: " + result + ", which is correct: " + (result == 4));

