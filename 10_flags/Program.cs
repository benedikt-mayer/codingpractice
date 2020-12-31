using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// 86% on codility: https://app.codility.com/demo/results/trainingGRYUE7-EE5/gi
int solution(int[] A)
{
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    List<int> distanceBetweenPeaks = new List<int>();
    int distance = 0;
    bool firstPeak = false;
    for (int index = 1; index < A.Length - 1; index++)
    {
        if (A[index - 1] < A[index] && A[index + 1] < A[index])
        {
            distanceBetweenPeaks.Add(distance);
            firstPeak = true;
            distance = 0;
        }
        if (firstPeak)
        {
            distance++;
        }
    }
    int currentNumberFlags = 1;
    int maxFlags = 0;
    if (distanceBetweenPeaks.Count == 1 || distanceBetweenPeaks.Count == 0)
    {
        return distanceBetweenPeaks.Count;
    }
    while (currentNumberFlags * currentNumberFlags <= A.Length && currentNumberFlags <= distanceBetweenPeaks.Count)
    {
        int currentNumberPeaks = 0;
        int accumulatedDistance = 0;

        // Console.WriteLine("current number of flags: " + currentNumberFlags);
        foreach (int peakDistance in distanceBetweenPeaks)
        {
            accumulatedDistance += peakDistance;
            // Console.WriteLine("current peak distance: " + peakDistance);
            if (peakDistance == 0)
            {
                currentNumberPeaks++;
                // Console.WriteLine("found flag at flags: " + currentNumberFlags + " with distance: " + accumulatedDistance);
            }
            else if (currentNumberFlags <= accumulatedDistance)
            {
                if (currentNumberPeaks < currentNumberFlags)
                {
                    // Console.WriteLine("found flag at flags: " + currentNumberFlags + " with distance: " + accumulatedDistance);
                    currentNumberPeaks++;
                    accumulatedDistance = 0;
                }
            }
        }
        maxFlags = Math.Max(maxFlags, currentNumberPeaks);
        currentNumberFlags++;
    }
    return maxFlags;
}

int[] aTest = { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
Console.WriteLine("testing with list aTest: " + solution(aTest));
