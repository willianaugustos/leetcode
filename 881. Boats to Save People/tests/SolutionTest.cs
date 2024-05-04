namespace tests;

public class SolutionTest
{
    [Theory]
    [InlineData(new [] {1, 2 }, 3, 1)] //Example 1
    [InlineData(new [] {3, 2, 2, 1}, 3, 3)] //Example 2
    [InlineData(new [] {3, 5, 3, 4}, 5, 4)] //Example 3
    [InlineData(new [] {5}, 5, 1)]
    [InlineData(new [] {3, 3}, 3, 2)]
    [InlineData(new [] {5, 3, 1}, 6, 2)]
    [InlineData(new [] {5, 3}, 8, 1)]
    [InlineData(new [] {2, 2}, 6, 1)]
    [InlineData(new [] {4, 4, 1}, 6, 2)]
    [InlineData(new [] {5, 4, 3, 2, 1, 1, 1}, 7, 4)]
    public void SolutionTestCases(int[] people, int limit, int expected)
    {
        var quantity = Solution.NumRescueBoats(people, limit);
        Assert.Equal(expected, quantity);
    }
}