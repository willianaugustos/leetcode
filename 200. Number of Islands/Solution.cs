namespace _200._Number_of_Islands
{
    public class Solution
    {
        private HashSet<(int, int)> visited = new();
        public int NumIslands(char[][] grid)
        {
            var nIslands = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == '1' && !visited.Contains((row, col)))
                    {
                        analyseArea(grid, row, col);
                        nIslands++;
                    }
                }
            }

            return nIslands;
        }

        private void analyseArea(char[][] grid, int row, int col)
        {
            if (visited.Contains((row, col)))
                return;

            if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length)
                return;

            if (grid[row][col] == '0')
                return;

            visited.Add((row, col));
            analyseArea(grid, row + 1, col);
            analyseArea(grid, row - 1, col);
            analyseArea(grid, row, col + 1);
            analyseArea(grid, row, col - 1);
        }
    }
}
