public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int req = target - nums[i];
            if (dict.ContainsKey(req)) {
                return new int[] { dict[req], i };
            }
            dict[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}
