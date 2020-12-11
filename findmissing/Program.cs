using System;
using System.Collections.Generic;
using System.Linq;

int FindMissing(int[] all, int[] fewer){
    HashSet<int> fewerSet = new HashSet<int>(fewer);
    foreach(int candidate in all){
        if (!fewerSet.Contains(candidate)){
            return candidate;
        }
    }
    return -1;
}

int FindMissingAlternative(int[] all, int[] fewer){
    HashSet<int> allSet = new HashSet<int>(all);
    HashSet<int> fewerSet = new HashSet<int>(fewer);
    foreach(int toRemove in fewerSet){
        allSet.Remove(toRemove);
    }
    return allSet.ToList().FirstOrDefault();
}

int FindMissingDirectly(int[] all, int[] fewer){
    HashSet<int> allSet = new HashSet<int>(all);
    allSet.ExceptWith(fewer);
    return allSet.ToList().FirstOrDefault();
}

int FindMissingBySum(int[] all, int[] fewer){
    return all.Sum() - fewer.Sum();
}

int[] fullSet = {4,12,9,5,6};
int[] partialSet = {4,12,9,6};

Console.WriteLine(FindMissing(fullSet, partialSet));
Console.WriteLine(FindMissingAlternative(fullSet, partialSet));
Console.WriteLine(FindMissingDirectly(fullSet, partialSet));
Console.WriteLine(FindMissingBySum(fullSet, partialSet));
