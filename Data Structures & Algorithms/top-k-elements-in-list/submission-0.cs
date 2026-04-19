public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        int[] arr=new int[k];
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num))
            dict[num]++;
            else
            dict[num]=1;
        }

         var topK = dict
                    .OrderByDescending(x => x.Value)
                    .Take(k)
                    .Select(x=>x.Key)
                    .ToArray();
          return topK;
        
    }
}
