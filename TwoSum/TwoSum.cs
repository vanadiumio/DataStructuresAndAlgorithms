public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict=new Dictionary<int,int>();
        for(var i=0;i<nums.Length;i++){
            var complement=target-nums[i];
            if(dict.ContainsKey(complement)){
                return [i,dict[complement]];
            }
            dict[nums[i]]=i;
        }
        return [];
    }
}