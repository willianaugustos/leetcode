using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace longest.domain;

public static class Solution
{
    public static int GetLongestStringWithNoRepeatingCharacter(string array)
    {
       int n = array.Length;
       int left=0;
       int solution=0;
       var listChars = new HashSet<char>();
       for(int right=0; right < n; right++)
        {
            while (listChars.Contains(array[right]))
            {
                listChars.Remove(array[left]);
                left++;
            }

            listChars.Add(array[right]);
            solution = Math.Max(solution, right - left +1);
        }
        return solution;
    }
}
