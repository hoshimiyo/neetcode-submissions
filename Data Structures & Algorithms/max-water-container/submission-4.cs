public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int area = 0;
        
        while(l < r){
            int result = (Math.Min(heights[l], heights[r])) * (r - l);
            area = Math.Max(area, result);

            if(heights[l] <= heights[r]){
                l++;
            }else{
                r--;
            }
        }
        return area;
    }
}
