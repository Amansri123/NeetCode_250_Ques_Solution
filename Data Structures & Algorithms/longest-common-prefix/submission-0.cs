public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         if (strs == null || strs.Length == 0)
            return "";

        string first = strs[0];

        for (int i = 0; i < first.Length; i++)
        {
            char current = first[i];

            for (int j = 1; j < strs.Length; j++)
            {
                // Check length OR mismatch
                if (i >= strs[j].Length || strs[j][i] != current)
                {
                    return first.Substring(0, i);
                }
            }
        }

        return first;

    }
}