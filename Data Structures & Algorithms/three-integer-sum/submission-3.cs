public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!freq.ContainsKey(num)){
                freq[num] = 0;
            }
            freq[num]++;
        }

        List<List<int>> res = new List<List<int>>();

        for(int i = 0; i < nums.Length; i++){
            freq[nums[i]]--;
            if(i > 0 && nums[i] == nums[i-1]) continue;

            for(int j = i + 1; j < nums.Length; j++){
                freq[nums[j]]--;
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;

                int target = -(nums[i] + nums[j]);
                if(freq.ContainsKey(target) && freq[target] > 0){
                    res.Add(new List<int> { nums[i], nums[j], target });
                }
            }

            for (int j = i + 1; j < nums.Length; j++) {
                freq[nums[j]]++;
            }
        }
        return res;
    }
}