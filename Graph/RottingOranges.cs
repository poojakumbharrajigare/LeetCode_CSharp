/*
You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.
*/

public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int, int, int)> queue = new Queue<(int row , int col, int time)>();
        int n = grid.Length;
        int m = grid[0].Length;
        int[,] visited = new int[n, m];
        int minTime = 0;
        int freshCount = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0 ; j < m; j++)
            {
                if(grid[i][j] == 2)
                {
                    queue.Enqueue((i,j,0));
                    visited[i, j] = 2;
                }
                else if(grid[i][j] == 1)
                    freshCount++;
            }
        }

        int[] dx = new int[] {0, -1, 0, 1};
        int[] dy = new int[] {1, 0, -1, 0};
        
        while(queue.Count > 0)
        {
            var (row, col, time) = queue.Dequeue();
            minTime = Math.Max(minTime, time);
            for(int k = 0; k < 4; k++)
            {
                int x = row + dx[k];
                int y = col + dy[k];

                if(x >= 0 && x < n && y >= 0&& y < m && visited[x, y] != 2 && grid[x][y] == 1)
                {
                    queue.Enqueue((x, y, time + 1));
                    visited[x, y] = 2;
                    freshCount--;
                }
            }
        }


        return freshCount == 0? minTime : -1;
    }
}