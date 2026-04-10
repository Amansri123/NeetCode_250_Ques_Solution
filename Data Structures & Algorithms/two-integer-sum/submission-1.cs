public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n=nums.Length;
        Dictionary<int,int> dict=new Dictionary<int,int>();
        for(int i=0;i<n;i++)
        {
            int diff=target-nums[i];
            if(dict.ContainsKey(diff))
            return new int[] {dict[diff],i};
             if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }
        return new int [0];
    }
}