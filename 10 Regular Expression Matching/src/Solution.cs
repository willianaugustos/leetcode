namespace src;
public static class Solution
{
    public static bool IsMatch(string s, string p)
    {
        int posP=0;
        List<Pattern> patterns = new();
        while (posP < p.Length)
        {
            if ((posP < p.Length-1) && (p[posP+1] == '*' ))
            {
                patterns.Add(new Pattern(p[posP], p[posP+1]));
                posP+=2;    
                continue;
            }

            patterns.Add(new Pattern(p[posP], '1'));
            posP++;
        }

        foreach (var item in patterns)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        return true;
    }
}

public class Pattern
{
    public char Key {get;init;}
    public char Value {get;init;}
    public Pattern(char _s, char _p)
    {
        Key = _s;
        Value= _p;
    }
}
