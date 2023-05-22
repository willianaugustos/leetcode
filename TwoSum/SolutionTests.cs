namespace TwoSum;

public class SolutionTests
{
    [Theory]
    [InlineData(new int[] {2,7,11,15}, 9, new int[] {0, 1})]
     [InlineData(new int[] {3,2,4}, 6, new int[] {1, 2})]
      [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void TestCases(int[] nums, int target, int[] expectedResult)
    {
        var solution = new TwoSum.Solution();
        var result = solution.TwoSum(nums, target);
        Assert.Equal(expectedResult, result);
    }
}