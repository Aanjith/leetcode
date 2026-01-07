public class Solution 
{
    public int SubarraySum(int[] nums, int k) 
    {
    int count = 0;
    int[] doop = nums;
    for (int i = 1; i < nums.Length; i++)
    {
        doop[i] = doop[i] + doop[i - 1];
    }

    for (int a = 0; a < nums.Length - 1; a++)
    {
        for (int j = a + 1; j < nums.Length; j++)
        {
            if (doop[j] - doop[a] == k)
            {
                count++;
            }
        }
    }

    foreach(int i in doop)
    {
        if(i==k)
        {
            count++;
        }
    }

    return count;
}
}