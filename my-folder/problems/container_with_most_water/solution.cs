public class Solution {
    public int MaxArea(int[] height) 
    {
        int start = 0, end, maxArea = 0,area = 0;
end = height.Length - 1;

while (start < end)
{
    int small;
    if(height[start] < height[end])
    {
        small = height[start];
    }
    else
    {
        small = height[end];
    }

    area = small * (end - start);
    if (area > maxArea) maxArea = area;

    if(small == height[start])
    {
        start++;
    }
    else
    {
        end --;
    }
}

return maxArea;   
    }
}