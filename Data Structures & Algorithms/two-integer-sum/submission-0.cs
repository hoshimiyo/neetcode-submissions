public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = nums.Length - 1; j > i; j--){
                if(nums[i] + nums[j] == target){
                    result[0]=i;
                    result[1]=j;
                }  
            }
        }
        return result;
    }
}
