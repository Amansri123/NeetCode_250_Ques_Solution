// National Dutch Method
// When Inout is huge and you want to categories Positive at one place,
// negative at diff place and so on..... 
// Use in K-partionining Algo
//Uses 3 Pointers Technique

// Eg:[1,0,1,2]
// Introduce 3 pointers low,mid,high
// low and mid =0 anf high=at last 
// if a[mid]==0 --> swap(a[low],a[mid]) and low++,mid++
// else if a[mid]==1-->m++;
// else swap(a[mid],a[high]) and high--;
// Basically lets suppose {[0,0,0,0],[1,1,1,1],[1,0,2,1,0,1],[2,2,2,2]} -- Hypothetical condition
// here we assumning left most is 0 and 1 sorted order mid is unsorted which is given array and 
// righgt has 2 in sorted order.
// 0's start from 0 to low-1
// 1's start from low to mid-1
// unsorted array startes from mid to high
// 2's starts from high+1 to last elemnt of array.



public class Solution {
   public void SortColors(int[] nums)
{
    int low = 0, mid = 0, high = nums.Length - 1;

    while (mid <= high)
    {
        if (nums[mid] == 0)
        {
            Swap(nums, low, mid);
            low++;
            mid++;
        }
        else if (nums[mid] == 1)
        {
            mid++;
        }
        else // nums[mid] == 2
        {
            Swap(nums, mid, high);
            high--;
        }
    }
}

private void Swap(int[] nums, int i, int j)
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}
}
   