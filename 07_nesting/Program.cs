using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int solution(string S) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    if (String.IsNullOrEmpty(S)){
        return 1;
    }
    Stack<char> stack = new Stack<char>(S.Length);
    foreach(char character in S){
        if (stack.Count == 0){
            stack.Push(character);
        } else{
            if ((stack.Peek() == '(') && (character == ')')){
                stack.Pop();
            } else{
                stack.Push(character);
            }
        }
    }
    if (stack.Count > 0){
        return 0;
    } else{
        return 1;
    }
}
String trueInput = "(()(())())";
String falseInput = "())";
Console.WriteLine("is trueInput correct: " + (solution(trueInput) == 1));
Console.WriteLine("is falseInput correct: " + (solution(falseInput) == 0));