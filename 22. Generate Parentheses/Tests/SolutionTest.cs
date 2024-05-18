using Domain;
namespace Tests;

public class SolutionTest
{
    [Theory]
    [InlineData(1, new string[] {"()"})]
    [InlineData(2, new string[] {"()()", "(())"})]
    [InlineData(3, new string[] {"()()()", "((()))", "(())()", "()(())", "(()())"})]
    public void TestCases(int n, string[] expected)
    {
        var result = Solution.GenerateParenthesis(n);
        Assert.Equal(expected, result);
    }
}