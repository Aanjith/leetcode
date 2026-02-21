public class Solution {
    //k = number of steps 
    //endPos - startPos = diff 
    //x + y = k (x = number of +1 and y = number of -1)
    //x - y = diff
    //x = (k+diff)/2
    //y = (k-diff)/2
    public int NumberOfWays(int startPos, int endPos, int k) 
    {
        int diff = Math.Abs(endPos - startPos);
        if(diff%2 != k%2 || k < Math.Abs(diff))
            return 0;

        BigInteger combinations = CalculateFactorialIterative(k)/(CalculateFactorialIterative((k+diff)/2) * CalculateFactorialIterative((k-diff)/2));
        //return (int)(combinations%Math.Pow(10,9)+7);
        //int modulo = (int)(combinations
        try{
        return (int)combinations;    
        }
        catch{
        return (int)(combinations% (BigInteger)(Math.Pow(10,9) + 7));
            }
                }

    public static BigInteger  CalculateFactorialIterative(int number)
    {
        // Factorial is defined for non-negative integers.
        if (number < 0)
        {
            throw new ArgumentException("Number must be non-negative.", nameof(number));
        }

        // 0! is defined as 1.
        if (number == 0)
        {
            return 1;
        }

        BigInteger   result = 1;
        for (int i = 1; i <= number; i++)
        {
            // Use BigInteger to handle large factorial results which quickly exceed
            // the capacity of standard int or long types (int goes up to 12!, long up to 20!).
            result *= i; 
        }
        return result;
    }
}