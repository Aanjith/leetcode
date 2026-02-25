public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int index1=0, index2 =0;    
        int[] arr = new int[nums1.Length+nums2.Length];

        for(int i =0;i<= nums1.Length+nums2.Length-1; i++)
        {
            if(index1<nums1.Length && index2<nums2.Length)
            {
                if(nums1[index1] < nums2[index2])
                {
                    arr[i] = nums1[index1];
                    index1++; 
                }
                else if(nums2[index2] < nums1[index1])
                {
                    arr[i] = nums2[index2];
                    index2++;
                }
                else
                {
                    arr[i] = nums1[index1];
                    index1++; 
                }
            }
            else
            {
                if(index1>=nums1.Length)
                {
                    arr[i] = nums2[index2];
                    index2++;
                }
                else if(index2>=nums2.Length)
                {
                    arr[i] = nums1[index1];
                    index1++;
                }
            }
        }

        double median;
        if((nums1.Length+nums2.Length)%2 == 1)
        {
            median = arr[(nums1.Length+nums2.Length)/2];
        }
        else
        {
            median = arr[(nums1.Length+nums2.Length)/2] + arr[(nums1.Length+nums2.Length-1)/2];
            median = median/2;
        }
        return median;
    }
}