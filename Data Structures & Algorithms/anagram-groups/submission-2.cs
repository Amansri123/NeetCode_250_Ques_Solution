// Input: strs = ["act","pots","tops","cat","stop","hat"]
// Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]

//Approach
// eg. ["eat","tea"]
// Define the Dictionary of datatype <string (Key),List of string(value)>
// Now, Traverse and take the first word, now usko sort krdo.
// Ab after sorting -- aet aayega ab dict mei aet wala koi hoga toh list mei add kr do wrna 
// ussi se nikal do.


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
