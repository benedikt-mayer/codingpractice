using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 100% in codility
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int minStock = Int32.MaxValue;
    int profit = 0;
    foreach(int stockValue in A){
        if (stockValue > minStock){
            profit = Math.Max(profit, stockValue - minStock);
        } else {
            minStock = stockValue;
        }
    }
    return profit;
}
