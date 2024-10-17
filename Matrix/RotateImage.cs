/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
*/

public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;

        // transpose of matrix.. iterate through only upper half of the matrix
        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                Swap(ref matrix[i][j], ref matrix[j][i]);
            }
        }

        //reverse each row.. traverse till half of the row.
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n / 2; j++)
                {
                    Swap(ref matrix[i][j], ref matrix[i][n - j - 1]);
                }
            }
        }
    }

    private void Swap(ref int number1, ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
}