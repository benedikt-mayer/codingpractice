using System;
using System.Collections.Generic;

List<int> example1 = new List<int> { 5, 2, 99, 3, 4, 1, 100 };
// {1,2,3,4,5,99,100}

int MaxConsecutive(List<int> inputList)
{
    inputList.Sort();
    int currentConsecutive = 1;
    int maxLength = 0;
    for (int i = 0; i < inputList.Count - 1; i++)
    {
        int currentElement = inputList[i];
        int nextElement = inputList[i + 1];
        if (currentElement + 1 == nextElement)
        {
            currentConsecutive++;
        }
        else
        {
            if (currentConsecutive > maxLength)
            {
                maxLength = currentConsecutive;
            }
            currentConsecutive = 1;
        }
    }
    return maxLength;
}

int MaxConsecutiveHashSet(List<int> inputList)
{
    HashSet<int> hashedInput = new HashSet<int>(inputList);
    int currentConsecutive;
    int maxLength = 0;
    foreach (int currentElement in hashedInput)
    {
        (currentConsecutive, hashedInput) = ContainsNext(hashedInput, (currentElement, currentElement));
        if (currentConsecutive > maxLength)
        {
            maxLength = currentConsecutive;
        }
    }
    return maxLength+1;
}

(int, HashSet<int>) ContainsNext(HashSet<int> hashedInput, (int, int) resultList)
{
    if (hashedInput.Contains(resultList.Item1-1))
    {
        hashedInput.Remove(resultList.Item1);
        resultList.Item1 = resultList.Item1-1;
        return ContainsNext(hashedInput, resultList);
    }
    else if (hashedInput.Contains(resultList.Item2+1))
    {
        hashedInput.Remove(resultList.Item2);
        resultList.Item2 = resultList.Item2+1;
        return ContainsNext(hashedInput, resultList);
    }
    else
    {
        return (resultList.Item2 - resultList.Item1, hashedInput);
    }
}

// Console.WriteLine(MaxConsecutive(example1));
Console.WriteLine(MaxConsecutiveHashSet(example1));