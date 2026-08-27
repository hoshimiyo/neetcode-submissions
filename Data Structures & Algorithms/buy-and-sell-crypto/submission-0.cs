public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int res = 0;
        while(r < prices.Length){
            if(prices[l] < prices[r]){
                int diff = prices[r] - prices[l];
                res = Math.Max(res, diff);
            } else {
                l = r;
            }
            r++;            
        }
        return res;
    }
}
