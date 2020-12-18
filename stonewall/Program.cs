using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// this has 100% with O(n)
int solution(int[] H) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    Stack<int> blocks = new Stack<int>(H.Length);
    blocks.Push(0);
    int neededBlocks = 0;
    foreach(int currentHeight in H){
        while (blocks.Peek() > currentHeight){
            blocks.Pop();
        } 
        if (blocks.Peek() < currentHeight){
            neededBlocks++;
            blocks.Push(currentHeight);
        } 
    }
    return neededBlocks;
}
int[] input = {8, 8, 5, 7, 9, 8, 7, 4, 8};
Console.WriteLine(solution(input));