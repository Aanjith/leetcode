public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var n = nums.Length;
        int[] array = new int[n];

        array[0] = 1;
        for(int i = 1; i < n; i ++)//setting prefix prod - the prefix prod of first element = 1
        {
            array[i] = array[i - 1] * nums[i - 1];
        }

        var product = 1;
        for(int i = n-1; i>=0; i--)
        {
        
            array[i] = array[i] * product;
            product = product * nums[i];
        }
        return array;
    }
}