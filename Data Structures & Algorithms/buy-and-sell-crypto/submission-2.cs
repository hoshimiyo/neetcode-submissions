public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        for(int i = 0; i < prices.Length; i++){
            for(int j = i + 1; j < prices.Length; j++){
                int profit = prices[j] - prices[i];
                res = Math.Max(profit, res);
            }
        }
        return res;
    }
}
