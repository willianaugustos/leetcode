namespace longest.tests;
using longest.domain;

public class SolutionTests
{
    [Theory]
    [InlineData("abcabcd", 4)]
    [InlineData("aaaaaaaaaaabcaaaaaaaaaaa", 3)]
    [InlineData("aaaaaaaaaaabaaaaaaaaaaa", 2)]
    [InlineData("baaaaaaaaaaaaaaaaaaaaaa", 2)]
    public void Test1(string array, int expected)
    {
       //act
       var result = Solution.GetLongestStringWithNoRepeatingCharacter(array);
       //assert
       Assert.Equal(expected, result);
    }
}