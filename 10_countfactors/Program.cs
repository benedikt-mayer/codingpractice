using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% on codility
int solution(int N) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int factors = 0;
    long i = 1;
    long nLong = (long) N;
    while(i * i < nLong){
        if (nLong % i == 0){
            factors += 2;
        }
        i++;
    }
    if (i * i == nLong){
        factors += 1;
    }
    return factors;
}

int N = 24;
Console.WriteLine("number N: " + N + " has " + solution(N) + " factors.");