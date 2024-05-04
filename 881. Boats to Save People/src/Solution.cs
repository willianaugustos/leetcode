using System.IO.Pipes;
using System.Linq.Expressions;
using System.Linq;

public static class Solution
{
    public static int NumRescueBoats(int[] people, int limit)
    {
        //copied solution from user: https://leetcode.com/Rutvik_Jasani/
        int boats = 0;
        Array.Sort(people);
        int i=0,j=people.Length-1;
        while(i<=j){
            if((people[j]+people[i])<=limit){
                i++;
            }
            j--;
            boats++;
        }
        return boats;
    }
    public static int NumRescueBoats2(int[] people, int limit)
    {
        //my solution that didn't solved the problem at all
        //lessons learned:
        //don't ever avoid to Sort an Array at beggining
        //when write a lot of code, I'm probably in the wrong way
        //when the problem consists in arrays and find combinations, probably the solution is sliding window

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

        //allocate remaining people
        if (dict.Count>0)
        {
            var ordered = dict.OrderByDescending(x=>x.Key);
            var currentWeightKey = ordered.ElementAt(0).Key;
            var currentWeightValue = ordered.ElementAt(0).Value;
            if (currentWeightKey < limit / 2)
            {
                boats += currentWeightValue / 2;
                dict.Remove(currentWeightKey);
            }
        }

        return boats + dict.Sum(s=>s.Value);
    }
}