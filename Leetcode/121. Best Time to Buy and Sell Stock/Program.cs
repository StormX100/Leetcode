/*
  You are given an array prices where prices[i] is the price of a given stock on the ith day.
  You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
 */

Solution solution = new Solution();
Console.WriteLine(solution.GetMaxProfit(new int[] { 7, 1, 5, 3, 6, 4 })); //5
Console.WriteLine(solution.GetMaxProfit(new int[] { 7, 6, 4, 3, 1 })); //0

public class Solution
{
    public int GetMaxProfit(int[] prices)
    {
        int minValue = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minValue) minValue = prices[i];
            if (prices[i] - minValue > maxProfit) maxProfit = prices[i] - minValue;
        }

        return maxProfit;
    }

    public int GetMaxProfitNonOptimal(int[] prices)
    {
        int maxProfit = 0;

        // works but exceeds time limit for a lot of prices
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] - prices[i] > maxProfit)
                {
                    maxProfit = prices[j] - prices[i];
                }

            }
        }

        return maxProfit;
    }
}