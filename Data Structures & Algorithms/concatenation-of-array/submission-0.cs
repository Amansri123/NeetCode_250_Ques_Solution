public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n=nums.Length;
        int[] Duplicate= new int[n*2];
        for(int i=0;i<n;i++)
        {
            Duplicate[i]=nums[i];
            Duplicate[i+n]=nums[i];
        }
        return Duplicate;
    }
}