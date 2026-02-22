public class Solution {
    //start or endIndex has only one interval 2*(startIndex - endIndex)
    //the other indexes can have two intervals = 2*(end index - currentIndex) and 2*(currentIndex - 0)
    public string Convert(string s, int numRows) 
    {
        int index = 0;
        string result = "";
        while(index<=numRows-1)
        {
            if(index == 0 || index == numRows-1)
            {
                int interval = 2*(numRows-1) ==0 ?1:2*(numRows-1);
                var currentIndex = index;
                while(currentIndex<=s.Length-1)
                {
                    result = result + (s[currentIndex]).ToString();
                    currentIndex+= interval;
                }
            }
            else
            {
                int interval1 = 2*((numRows-1) - index) == 0? 1:2*((numRows-1) - index);
                int interval2 = 2*(index-0) == 0? 1 : 2*(index-0) ;
                var currentIndex = index;
                int oddOrEven = -1;
                while(currentIndex <= s.Length-1)
                {
                    result =  result + (s[currentIndex]).ToString();
                    if(oddOrEven == -1)
                    currentIndex+= interval1;
                    else
                    currentIndex+= interval2;

                    oddOrEven*=-1;
                }

            }



            index++;
        }
        return result;
    }



    
}