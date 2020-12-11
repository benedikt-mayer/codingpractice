using System;
using System.Collections.Generic;
using System.Linq;

List<int> A = new List<int>{80,20,1,50,10,10,10,10,10};
List<int> B = new List<int>{-1,3,-4,5,1,-6,2,1};
int ReturnEquilibrium(List<int> input){
    List<int> leftCumSum = new List<int>();
    int sum = input.Sum();
    int cumSum = 0;

    foreach(int number in input){
        cumSum = cumSum + number;
        leftCumSum.Add(cumSum);
    }
    for(int index = 0; index < input.Count-1; index++){
        int leftSum = leftCumSum[index];
        int currentValue = input[index+1];
        int rightSum = sum - leftSum - currentValue;
        if (leftSum == rightSum){
            Console.WriteLine("equilibrium index: " + (index+1) + " for value: " + currentValue);
            Console.WriteLine("left sum is: " + leftSum + ", right sum is: " + rightSum);
            return (index+1);
        }
    }
    return -1;
}
Console.WriteLine("equilibrium for A found at: " + ReturnEquilibrium(A));
Console.WriteLine("equilibrium for B found at: " + ReturnEquilibrium(B));