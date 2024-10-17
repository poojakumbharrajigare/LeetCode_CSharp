/*
You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int column = n - 1;
        int row = 0;
        bool result = false;

        while(row < m && column >= 0)
        {
            if(matrix[row][column] == target)
            {
                result = true;
                break;
            }
            else if(matrix[row][column] > target)
                column--;
            else
                row++;
        }

        return result;
    }
}