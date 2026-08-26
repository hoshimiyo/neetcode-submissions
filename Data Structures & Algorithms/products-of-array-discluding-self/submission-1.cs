public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeroCount = 0;
        int prod = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                zeroCount++;
            }
            else {
                prod *= nums[i];
            }
        }
        if(zeroCount > 1){
            return new int[nums.Length];
        }
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(zeroCount == 1){
                if(nums[i] == 0){
                    res[i] = prod;
                } else {
                    res[i] = 0;
                }
            }
            if(zeroCount == 0){
                res[i] = prod / nums[i];
            }
        }
        return res;
    }
}
