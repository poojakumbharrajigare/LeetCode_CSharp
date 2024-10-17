/*
Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
You may assume all four edges of the grid are all surrounded by water.
*/

public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;
        int m = grid.Length;
        int n = grid[0].Length;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(grid[i][j] != '2' && grid[i][j] != '0')
                {
                    result++;
                    dfs(ref grid, i, j);
                }
            }
        }

        return result;
    }

    private void dfs(ref char[][] grid, int i, int j)
    {
        grid[i][j] = '2';
        int m = grid.Length;
        int n = grid[0].Length;
        int[] dx = new int[]{ 0, -1, 1, 0};
        int[] dy = new int[]{ -1, 0, 0, 1};

        for(int k = 0; k < dx.Length; k++)
        {
            int x = i + dx[k];
            int y = j + dy[k];

            if(x >= 0 && y >= 0 && x < m && y < n && grid[x][y] == '1')
            {
                dfs(ref grid, x, y);
            }
        }
    }
}