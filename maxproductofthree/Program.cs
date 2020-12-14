using System.Collections.Generic;
using System.Linq;
using System;

// goal: find all the corner cases
int solution(int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    List<int> sortedA = A.ToList();
    sortedA.Sort();
    int[] sortedArrayA = sortedA.ToArray();
    int[] positiveLargest = sortedArrayA.Where(element => element > 0).Reverse().Take(3).ToArray();
    int[] negativeLargest;
    if (positiveLargest.Length >=1){
        negativeLargest = sortedArrayA.Where(element => element <= 0).Take(3).ToArray();
    } else{
        negativeLargest = sortedArrayA.Where(element => element <= 0).Reverse().Take(3).ToArray();
    }
    int[] maximumValues = positiveLargest.Concat(negativeLargest).ToArray();
    int maxProduct = int.MinValue;
    for(int p = 0; p < maximumValues.Length; p++){
        for(int q = p+1; q < maximumValues.Length; q++){
            for(int r = q+1; r < maximumValues.Length; r++){
                int currentProduct = maximumValues[p] * maximumValues[q] * maximumValues[r];
                maxProduct = Math.Max(maxProduct, currentProduct);
            }
        }
    }
    return maxProduct;
}

