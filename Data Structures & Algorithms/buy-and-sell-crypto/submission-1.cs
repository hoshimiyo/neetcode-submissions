public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int minBuy = prices[0];

        foreach(int sell in prices){
            max = Math.Max(max, sell - minBuy);
            minBuy = Math.Min(minBuy,sell);
        }
        return max;
    }
}