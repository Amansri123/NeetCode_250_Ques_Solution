public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> dict=new Dictionary<char,int>();
        Dictionary<char,int> dict1=new Dictionary<char,int>();

        //For Frequency of each character in string of s
        foreach(char ch in s)
        {
            if(dict.ContainsKey(ch))
            dict[ch]++; //Frequency add
            else
            dict[ch]=1;
        }

        //For Frequency of each character in string of t
        foreach(char ch in t)
        {
            if(dict1.ContainsKey(ch))
            dict1[ch]++; //Frequency add
            else
            dict1[ch]=1;
        }

        //Compare the each characters of both the strings
        if(dict.Count != dict1.Count)
        return false;
        
        //Compare Frequency
        foreach(var pair in dict)
        {
            if(!dict1.ContainsKey(pair.Key) || dict1[pair.Key] != pair.Value)
            return false;
        }
        return true;
    
    }
}
