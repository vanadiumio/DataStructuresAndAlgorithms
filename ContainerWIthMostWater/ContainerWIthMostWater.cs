public class Solution {
    public int MaxArea(int[] height) {
        int left=0;
        int right=height.Length-1;
        int maxArea=0;
        for (int i = 0; i < height.Length; i++) {
        maxArea=Math.Max(maxArea,Math.Min(height[left],height[right])*(right-left));
        if(height[left]<height[right]){
            left++;
        }else{
            right--;
        }
    }
        return maxArea;
    }
}