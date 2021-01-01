using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int passingWest = A.Sum();
    int passingCars = 0;
    int passedWest = 0;
    for(int index = 0; index < A.Length; index++){
        int currentCar = A[index];
        if (currentCar == 1){
            passedWest++;
        } else{
            int remainingWest = passingWest - passedWest;
            passingCars += remainingWest;
            if (passingCars > 1000000000){
                return -1;
            }
        }
    }
    return passingCars;
}

int[] testSet = {1, 0, 1, 0, 1};
int testResult = 3;
Console.WriteLine
