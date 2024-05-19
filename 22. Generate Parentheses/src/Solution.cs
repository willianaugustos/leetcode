namespace Domain;

public class Solution
{
    private List<string> result = new();

    public IList<string> GenerateParenthesis(int n)
    {
        RecursiveSolve("", n, 0);
        return result;
    }

    private void RecursiveSolve(string current, int leftSide, int rightSide)
    {
        if ((leftSide, rightSide) == (0,0))
        {
            result.Add(current);
            return;
        }

        if (leftSide >0)
        {
            RecursiveSolve(current+"(", leftSide-1, rightSide+1);
        }

        if (rightSide >0)
        {
            RecursiveSolve(current+")", leftSide, rightSide-1);
        }

        return;
    }
}
