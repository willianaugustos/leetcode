namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("abc", "a*b*c*", true)]
    [InlineData("abc", "c*ab.", true)]
    [InlineData("abc", ".*", false)]
    [InlineData("abc", ".*c", false)]
    [InlineData("abc", ".*cc", false)]
    [InlineData("abc", "..*c", true)]
    [InlineData("xxxxxxxxxxxxxxxxxxxxxx", ".*", true)]
    [InlineData("xxxxxxxxxxxxxxxxxxxxxx", ".*.*", true)]
    [InlineData("xxxxxxxxxyyyyyyyyyyyyy", ".*.*", true)]
    [InlineData("", ".*", true)]
    [InlineData("w", ".*.*", true)]
    public void TestCases(string s, string p, bool expected)
    {
        Console.WriteLine("---");
        var result = src.Solution.IsMatch(s, p);
        Assert.True(result == expected);
    }
}