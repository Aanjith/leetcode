public class Solution {
    public int LongestConsecutive(int[] nums)
{
    int maxLength = 0;
    var dict = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        if (dict.TryGetValue(num, out int __))
            continue;
        dict.Add(num, 1);
    }

    foreach (var num in nums)
    {
        if (dict[num] != 1)
        {
            continue;
        }

        var depth = GetSequenceLength(num, dict);

        if (depth > maxLength)
        {
            maxLength = depth;
        }

    }

    return maxLength;

}

public int GetSequenceLength(int num, Dictionary<int, int> dict)
{
    int value = 0;
    if (dict.TryGetValue(num - 1, out var _) == false)
    {
        return 1;
    }

    else if (dict.TryGetValue(num - 1, out value) == true)
    {
        if (value != 1)
        {
            dict[num] = dict[num] +  value;
        }

        else
        {
            var seq = GetSequenceLength(num - 1, dict);
            dict[num] = dict[num] + seq;
        }
    }

    return dict[num];


}
}