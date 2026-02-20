public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int startIndex = 0,currentIndex = 0,maxLength = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>(); 
        for(int i =0; i<s.Length; i++)
        {
            if(!dict.TryGetValue(s[i],out var Index))
            {
                dict.Add(s[i],i);
                currentIndex++;
            }
            
            else
            {
                if(currentIndex - startIndex > maxLength)
                {
                    maxLength = currentIndex - startIndex;
                }
                if (dict[s[i]] + 1 > startIndex)
                {
                    startIndex = dict[s[i]] + 1;
                }
                dict[s[i]] = i;
                currentIndex ++;
            }

            if(i == s.Length-1)
            {
                if(currentIndex - startIndex > maxLength)
                {
                    maxLength = currentIndex - startIndex;
                }
            }
        }
        return maxLength;
    }
}