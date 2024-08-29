/*
Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
*/


public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0)
            return 1;

        //when n is equal to Int32.MinValue
        if (n == Int32.MinValue) {
            n = -(n + 1);
            x = 1.0 / x;
            return x * x * MyPow(x * x, n / 2);
        }
        
        // if n is negative, invert x and make n positive
        if (n < 0) {
            x = 1.0 / x;
            n = -n;
        }
        
        if(n % 2 == 0)
        {
            double result = MyPow(x, n/2);
            return result * result;
        }
        else 
        {
            double result = MyPow(x, (n-1)/2);
            return result * result * x;
        }
    }
}