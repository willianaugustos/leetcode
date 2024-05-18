namespace Domain;

public static class Solution
{
    public static string[] GenerateParenthesis(int n)
    {
        List<string> list = new();
        string str = Solve(n, "");
        list.Add(str);
        return list.ToArray();
    }

    private static string Solve(int n, string current)
    {
        if (n==0)
        return ")";

        current = "(";
        var s= Solve(n-1, current);
        Console.WriteLine(s);
        return s;
    }
}
