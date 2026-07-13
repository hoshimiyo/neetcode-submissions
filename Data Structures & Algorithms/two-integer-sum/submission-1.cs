public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            result[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(result.ContainsKey(diff) && result[diff] != i)
            {
                return new int[]{i, result[diff]};
            }
        }

        return new int[0];
    }
}
