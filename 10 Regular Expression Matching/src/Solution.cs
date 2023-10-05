namespace src;
public static class Solution
{
    public static bool IsMatch(string s, string p)
    {
        int posP = 0;
        List<Pattern> patterns = new();
        Console.WriteLine($"Analysing pattern: {p} over word: {s}");
        while (posP < p.Length)
        {
            if ((posP < p.Length - 1) && (p[posP + 1] == '*'))
            {
                patterns.Add(new Pattern(p[posP], p[posP + 1]));
                posP += 2;
                continue;
            }

            patterns.Add(new Pattern(p[posP], '1'));
            posP++;
        }

        int posS = 0;
        foreach (var item in patterns)
        {
            if (posS >= s.Length)
                {
                    Console.WriteLine($"posS is greather than limit: {posS}, return false");
                    return false;
                }

            Console.WriteLine($"Checking: {item.Key} => {item.Value}");
            if (item.Value == '*')
            {
                Console.WriteLine("Find a *, inspect next...");
                char current = s[posS];
                do
                {
                    if ((s[posS] == item.Key || item.Key=='.') )
                    {
                        posS++;
                        Console.WriteLine($"Novo valor de posS={posS}");
                    }
                } while (posS < s.Length && (s[posS] == item.Key || (item.Key=='.' && s[posS]==current)));

                continue;
            }

            if (item.Value == '1' && (s[posS]!=item.Key && item.Key!='.'))
            {
                Console.WriteLine(">> Retornando False");
                return false;
            }

            posS++;
        }
        if (posS < s.Length-1)
        {
            Console.WriteLine($">> posS={posS} menor que o máximo, Retornando False");
            return false;    
        }
        Console.WriteLine(">> Retornando True");
        return true;
    }
}

public record Pattern(char Key, char Value);
