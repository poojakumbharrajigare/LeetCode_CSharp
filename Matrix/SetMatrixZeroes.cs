/*
Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

You must do it in place.
*/

public class Solution {
    public void SetZeroes(int[][] matrix) {
        // Check if 1st row and 1st column contains a 0
        bool Is1stRowHasZero = false;
        bool Is1stColumnHasZero = false;

        for(int j = 0; j < matrix[0].Length; j++)
        {
            if(matrix[0][j] == 0)
            {
                Is1stRowHasZero = true;
                break;
            }
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            if(matrix[i][0] == 0)
            {
                Is1stColumnHasZero = true;
                break;
            }
        }

        //Now, use 1st row and 1st column to indicate zero.
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        //Mark the corresponding row 0. Start from 2nd row, second column.
        for (int i = 1; i < matrix.Length; i++)
        {
            if(matrix[i][0] == 0)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        //Mark the corresponding column 0. Start from 2nd row, second column.
        for(int j = 1; j < matrix[0].Length; j++)
        {
            if(matrix[0][j] == 0)
            {
                for(int i = 1; i < matrix.Length; i++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // Now, as per the boolean flags mark first row as 0.
        if(Is1stRowHasZero)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // As per the boolean flags mark first column as 0.
        if(Is1stColumnHasZero)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}