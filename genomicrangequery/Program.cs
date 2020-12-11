using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Dictionary<char, int> letterToImpact = new Dictionary<char, int>(){
            {'A', 1},
            {'C', 2},
            {'G', 3},
            {'T', 4}
        };
        int[] impacts = S.Select(character => letterToImpact[character]).ToArray();
        int[,] prefixSums = new int[4, impacts.Length];

        for(int impactIndex = 0; impactIndex < impacts.Length; impactIndex++){
            int impactFactor = impacts[impactIndex];
            if (impactIndex > 0){
                for (int gene = 0; gene < 4; gene++){
                    prefixSums[gene, impactIndex] = prefixSums[gene, impactIndex-1];
                }
            } else{
                for (int gene = 0; gene < 4; gene++){
                    prefixSums[gene, impactIndex] = 0;
                }
            }
            prefixSums[impactFactor-1, impactIndex] += impactFactor;
        }
        List<int> results = new List<int>();
        for (int queryIndex = 0; queryIndex < P.Length; queryIndex++){
            int start = P[queryIndex] > 0 ? P[queryIndex]-1 : P[queryIndex];
            int end = Q[queryIndex];
            for(int gene = 0; gene < 4; gene++){
                if ((start == end || P[queryIndex] == 0) && (prefixSums[gene, end] > 0)){
                    if (P[queryIndex] == 0 && prefixSums[gene, P[queryIndex]] > 0){
                        results.Add(gene + 1);
                        gene = 4;
                    }else if (end > 0 && prefixSums[gene, end] > prefixSums[gene, start]){
                        results.Add(gene + 1);
                        gene = 4;
                    }
                } else if (prefixSums[gene, end] > prefixSums[gene, start]){
                    results.Add(gene + 1);
                    gene = 4;
                }
            }
        }
        return results.ToArray();
        
    }
}