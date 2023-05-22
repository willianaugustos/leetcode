namespace TwoSum;
public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result= System.Array.Empty<int>();
        var memo = new Dictionary<int, int>();
        for(int i=0; i<nums.Count(); i++)
        {
            if (memo.ContainsKey(target - nums[i]))
            {
                result = new int[] {memo[target - nums[i]], i};
                break;
            }

            //add if not exists in memo
            if (!memo.ContainsKey(nums[i]))
                memo.Add(nums[i], i);
            
        }
        return result;
    }
}