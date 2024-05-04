using System.IO.Pipes;
using System.Linq.Expressions;

public static class Solution
{
    public static int NumRescueBoats(int[] people, int limit)
    {
        var dict = new Dictionary<int,int>();
        var boats =0;
        for (int i = 0; i < people.Length; i++)
        {
            int currentWeight = people[i];

            //1st scenario: Person weight is exactly boat limit
            if (limit == currentWeight)
            {
                boats++;
                continue;
            }

            //2nd scenario: Person weight plus other previous person is exactly limit
            if (currentWeight > limit)
                throw new ArgumentException("Person overweighted, can't allocate to any boat");

            int peopleWithTargetWeight=0;
            if (dict.ContainsKey(limit - currentWeight))
            {
                peopleWithTargetWeight = dict[limit - currentWeight];
            }
                
            if (peopleWithTargetWeight > 0)
            {
                if (peopleWithTargetWeight == 1)
                    dict.Remove(limit - currentWeight);
                else
                    dict[limit - currentWeight] --;

                boats++;
                continue;
            }

            //add person to next check
            if (!dict.TryAdd(currentWeight, 1))
                dict[currentWeight] ++;
        }

        return boats + dict.Sum(x=>x.Value);
    }
}