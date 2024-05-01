namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1,2,3,1}, 3, true)]
    [InlineData(new int[] {1,0,1,1}, 1, true)]
    [InlineData(new int[] {1,2,3,1,2,3}, 2, false)]
    public void TestExpectedScenarios(int[] array, int k, bool expected)
    {
        var result = Solution.ContainsNearbyDuplicate(array, k);
        Assert.Equal(result, expected);
    }
}