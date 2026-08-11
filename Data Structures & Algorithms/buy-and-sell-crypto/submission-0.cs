public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int max = 0;
        while(r < prices.Length){
            if(prices[r] > prices[l]){
                int profit = prices[r] - prices[l];
                max = Math.Max(max, profit);
            }else{
                l = r;
            }
            r++;
        } 
        return max;
    }
}
