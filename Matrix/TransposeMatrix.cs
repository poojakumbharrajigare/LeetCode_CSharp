/*
Given a 2D integer array matrix, return the transpose of matrix.

The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
*/

public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int[][] transposed = new int[cols][];
        
        for (int i = 0; i < cols; i++) 
        {
            transposed[i] = new int[rows];
            for (int j = 0; j < rows; j++) 
            {
                transposed[i][j] = matrix[j][i];
            }
        }

        return transposed;
    }
}