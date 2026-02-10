public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var length = nums.Length;
        for(int i=0; i<length; i++)
        {
            while(nums[i]>0 &&
            nums[i]<=length &&
            nums[nums[i]-1] != nums[i]
            && nums[i] != i+1)
            {
                var number = nums[i] - 1;
                var swap = nums[i];
                nums[i] = nums[number];
                nums[number] = swap;
            }
        }

        for(int i=0; i<length; i++)
        {
            if(nums[i] != i+1)
            {
                return i + 1;
            }
        }

        return length +1;
    }
}