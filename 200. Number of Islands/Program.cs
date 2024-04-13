using _200._Number_of_Islands;

public static class Program
{

    public static void Main(string[] args)
    {
        char[][] grid = [
          ['0', '0', '0', '0', '0'],
            ['0', '0', '0', '0', '0'],
            ['0', '0', '0', '0', '0'],
            ['0', '0', '0', '0', '1']];

        var output = new Solution().NumIslands(grid);

        Console.WriteLine(output);
        Console.ReadKey();
    }
}