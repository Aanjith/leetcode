public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        int smallestWordAlphabetCount = int.MaxValue;
        string smallestWord = "";
        for(int i =0; i<strs.Length; i++)
        {
            if(strs[i].Length < smallestWordAlphabetCount)
            {
                smallestWordAlphabetCount = strs[i].Length;
                smallestWord = strs[i];
            }
        } 
         
        for(int i = 0; i<strs.Length; i++) 
        {
            var matchingPrefix = "";
            if(smallestWord == strs[i])
            {
                continue;
            }
            for(int j = 0; j<smallestWord.Length; j++)
            {
                
                if(smallestWord[j] == strs[i][j])
                {
                    matchingPrefix += smallestWord[j];
                } 
                else
                {
                    break;
                }              
            }

            if(matchingPrefix.Length < smallestWord.Length)
            {
                smallestWord = matchingPrefix;
            }
        }
        return smallestWord;
    }
}