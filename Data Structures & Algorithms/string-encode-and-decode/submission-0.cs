public class Solution {

    public string Encode(IList<string> strs) {
       StringBuilder sb = new StringBuilder();

    foreach (var str in strs)
    {
        sb.Append(str.Length).Append('#').Append(str);
    }

    return sb.ToString();
    }

    public List<string> Decode(string s) {
      List<string> result = new List<string>();
    int i = 0;

    while (i < s.Length)
    {
        int j = i;

        // find #
        while (s[j] != '#') j++;

        int length = int.Parse(s.Substring(i, j - i));

        j++; // move after '#'

        result.Add(s.Substring(j, length));

        i = j + length;
    }

    return result;
   }
}
