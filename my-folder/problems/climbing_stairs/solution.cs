public class Solution {
    public int ClimbStairs(int n) 
    {
        BigInteger combinations = 0; int i =0;
        while(n-2*i>=0)
        {
            combinations+= CalculateFactorialIterative(n-2*i+i)/(CalculateFactorialIterative(n-2*i)*CalculateFactorialIterative(i));


            i++;
        }
        return (int)combinations;
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