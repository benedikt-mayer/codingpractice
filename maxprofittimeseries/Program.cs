using System;

// this is very similar to 09_maxprofit.
Tuple<int, int, double> Solution(double[] pastData){
    double profit = 0;
    int bestBuyingIndex = -1;
    int bestSellingIndex = -1;
    for(int minIndex = 0; minIndex < pastData.Length; minIndex++){
        double buyingPrice = pastData[minIndex];
        for (int maxIndex = minIndex+1; maxIndex < pastData.Length; maxIndex++){
            double sellingPrice = pastData[maxIndex];
            if (sellingPrice-buyingPrice > profit){
                profit = sellingPrice-buyingPrice;
                bestBuyingIndex = minIndex;
                bestSellingIndex = maxIndex;
            }
        }
    }
    return new Tuple<int, int, double>(bestBuyingIndex, bestSellingIndex, profit);
}

double[] data = {105.0, 101.0, 102.0, 103.0, 100.0};
Console.WriteLine(Solution(data));