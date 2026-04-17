// National Dutch Method
// When Inout is huge and you want to categories Positive at one place,
// negative at diff place and so on..... 
// Use in K-partionining Algo
//Uses 3 Pointers Technique

public class Solution {
    public void SortColors(int[] nums) {
        int a=0;int b=0;int c=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            a++;
            else if (nums[i]==1)
            b++;
            else
            c++;
        }
        for(int i=0;i<a;i++)
        nums[i]=0;
        for(int i=a;i<a+b;i++)
        nums[i]=1;
        for(int i=b+a;i<nums.Length;i++)
        nums[i]=2;
    }
}
   