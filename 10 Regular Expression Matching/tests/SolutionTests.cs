namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("abc", "a*b*c*", true)]
    [InlineData("abc", "c*ab.", true)]
    [InlineData("abc", ".*", true)]
    [InlineData("abc", ".*c", true)]
    [InlineData("abc", ".*cc", false)]
    public void TestCases(string s, string p, bool expected)
    {
        Console.WriteLine("---");
        var result = src.Solution.IsMatch(s, p);
        Assert.True(result && expected);
    }
}