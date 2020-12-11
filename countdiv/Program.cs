using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int solution(int A, int B, int K) {
    int startValue = SmallestK(A, K);
    if (startValue > B){
        return 0;
    }
    return ((B-startValue) / K) + 1;
}
int SmallestK(int A, int K){
    if (A == 0){
        return 0;
    } else if (K > A){
        return K;
    } else if (A % K == 0){
        return A;
    } else{
        return A + (K-(A % K));
    }
}


Console.WriteLine(solution(0,0,11));