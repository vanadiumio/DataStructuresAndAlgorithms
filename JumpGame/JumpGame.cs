public class Solution {
    public bool CanJump(int[] nums) {
        int n=nums.Length;
        int goal=n-1;
        if(n==1){
            return true;
        }
        for(int i=n-1;i>=0;i--){
            if(i+nums[i]>=goal){
                goal=i;
            }
        }
        return goal==0;
    }
}