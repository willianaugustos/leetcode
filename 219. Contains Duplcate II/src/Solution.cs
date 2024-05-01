using System.Reflection.Emit;

public static class Solution {
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        (int i, int j, bool result) = (0, 0, false);
        
        while (i<nums.Length)
        {
            j=i+1;
            while (j<nums.Length && j-i <= k)
            {
                if (nums[j]==nums[i] && j-i<=k)
                {
                    result=true;
                    break;
                }
                j++;
            }
            i++;
        }
        return result;
    }
}