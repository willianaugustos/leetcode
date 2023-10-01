namespace tests;

public class SolutionTests
{
    [Theory]
    [InlineData(new int[]{2,3,4,5}, new int[]{1,2,4,4}, 2, 3)]
    [InlineData(new int[]{10,2,2}, new int[]{2,2,0}, 100, 3)]
    [InlineData(new int[]{6,2,3}, new int[]{0,0,0}, 6, 2)]
    [InlineData(new int[]{91,54,63,99,24,45,78}, new int[]{35,32,45,98,6,1,25}, 17, 1)]
    public void TestCase1(int[] capacity, int[] used, int available, int expectedResult)
    {
        var result = Solution.FillMaximumBags(capacity, used, available);
        Assert.Equal(expectedResult, result);
    }
}