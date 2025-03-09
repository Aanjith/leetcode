public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(var i = 0; i<nums.Count();i++)
        {
            for(var j=i+1;j<nums.Count();j++)
            {
                if(nums[i]+nums[j]==target)
                {
                    return ([i,j]);
                    //Console.WriteLine($"[{i},{j}]");
                    //break;
                }
            }
            
        }
        return ([1,2]);
    }
}
        
        
    
