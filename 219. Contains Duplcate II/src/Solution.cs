using System.Reflection.Emit;

public static class Solution {
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        (int i, int j, bool result) = (0, 0, false);
        
        while (i<nums.Length)
        {
            j=i+1;
            while (j<nums.Length)
            {
                if (nums[j]==nums[i] && Math.Abs(i-j)<=k)
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