public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //Create the new dictionary
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    //Traverse to each word
       for(int i=0;i<strs.Length;i++)
       {
            //convert to character array and then sort
            char[] arr=strs[i].ToCharArray();
            Array.Sort(arr);
            //Again character->String
            string str=new string(arr);

            //If sorted is not available then create the key of List Type
            if(!dict.ContainsKey(str))
            {
                dict[str]=new List<String>();
            }
            //If dict has that key then uss list mei uski value daaldo.
            dict[str].Add(strs[i]);
       }
       return dict.Values.ToList<List<string>>();

    }
}
