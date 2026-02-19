public class Solution {
    public int MyAtoi(string s) 
    {
        if (string.IsNullOrEmpty(s))
    return 0;

int i = 0, n = s.Length, result = 0, sign = 1;

while (i < n && s[i] == ' ')//whitespace
{
    i++;
}

if (i < n && s[i] == '-')
{
    sign = -1;
    i++;
}
else if (i < n && s[i] == '+')
{
    sign = +1;
    i++;
}

int maxBy10 = int.MaxValue / 10;
while (i < n && char.IsDigit(s[i]))
{
    int digit = s[i] - '0';
    if (result > maxBy10)
    {
        result = sign == -1 ? int.MinValue : int.MaxValue;
        return result;
    }
    else if(result == maxBy10)
    {
        if(sign == -1 && digit >= 8)
        {
            return int.MinValue;
        }
        else if (sign == 1 && digit >= 7)
        {
            return int.MaxValue;
        }
        result = result * 10 + digit;
    }
    else
    {
        result = result * 10 + digit;
    }
    i++;
}
return sign * result;
}
}