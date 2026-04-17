public class Solution 
{
    public int[] SortArray(int[] nums) 
    {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    private void Merge(int[] nums, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = nums[left + i];

        for (int j = 0; j < n2; j++)
            rightArr[j] = nums[mid + 1 + j];

        int i1 = 0, j1 = 0, k = left;

        while (i1 < n1 && j1 < n2)
        {
            if (leftArr[i1] <= rightArr[j1])
                nums[k++] = leftArr[i1++];
            else
                nums[k++] = rightArr[j1++];
        }

        while (i1 < n1)
            nums[k++] = leftArr[i1++];

        while (j1 < n2)
            nums[k++] = rightArr[j1++];
    }
}