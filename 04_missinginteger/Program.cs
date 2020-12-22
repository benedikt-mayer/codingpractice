using System;
using System.Collections.Generic;

Console.WriteLine("hello");

int[] test1 = { 1, 3, 6, 4, 1, 2 };
int[] test2 = { 1, 2, 3 };
int[] test3 = { -1, -3 };
int[] test4 = { 1 };

// n^2 according to codility - depends on SortedSet performance
int solution(int[] A)
{
    int smallest = 1;
    SortedSet<int> ASet = new SortedSet<int>(A);
    foreach (int candidate in ASet)
    {
        if (candidate == smallest)
        {
            smallest += 1;
        }
    }
    return smallest;
}

// 100% on codility with O(N) or O(N log N)
int solution2(int[] A)
{
    int smallest = 1;
    HashSet<int> hashedA = new HashSet<int>(A);
    foreach (int candidate in hashedA)
    {
        if (candidate == smallest)
        {
            smallest = FindSmallest(candidate, hashedA);
        }
    }
    return smallest;
}

int FindSmallest(int candidate, HashSet<int> hashedA)
{
    if (hashedA.Contains(candidate + 1))
    {
        return FindSmallest(candidate + 1, hashedA);
    }
    else
    {
        return candidate + 1;
    }
}

Console.WriteLine("solution 1, test1: " + solution(test1) + " is correct: " + (solution(test1) == 5));
Console.WriteLine("solution 1, test2: " + solution(test2) + " is correct: " + (solution(test2) == 4));
Console.WriteLine("solution 1, test3: " + solution(test3) + " is correct: " + (solution(test3) == 1));
Console.WriteLine("solution 1, test4: " + solution(test4) + " is correct: " + (solution(test4) == 2));
Console.WriteLine("solution 2, test1: " + solution2(test1) + " is correct: " + (solution2(test1) == 5));
Console.WriteLine("solution 2, test2: " + solution2(test2) + " is correct: " + (solution2(test2) == 4));
Console.WriteLine("solution 2, test3: " + solution2(test3) + " is correct: " + (solution2(test3) == 1));
Console.WriteLine("solution 2, test4: " + solution2(test4) + " is correct: " + (solution2(test4) == 2));