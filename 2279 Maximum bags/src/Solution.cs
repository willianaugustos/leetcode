
namespace maximum_bags
{


public static class Solution
{
    public static int FillMaximumBags(int[] capacity, int[] used, int available)
    {
        var bags = new Dictionary<int,int>();
        
        //map available slots
        for (int i = 0; i < capacity.Length; i++)
        {
            int slots = capacity[i] - used[i];
            if (bags.ContainsKey(slots))
            {
                bags[slots] ++;
            }
            else
            {
                bags.Add(slots, 1);
            }
        }

        //traverse filling by descending order
        int bagsFilled = 0;
        Console.WriteLine($"Iniciando... Available = {available}");
        foreach (var item in bags.OrderBy(f=>f.Key))
        {
            Console.WriteLine($"Item Key={item.Key} Value={item.Value}");
            if (available >= (item.Key * item.Value))
            {
                available = available - (item.Key * item.Value);
                bagsFilled += item.Value;
            }
            else
            {
                bagsFilled+= available / item.Key;
                available = 0;
            }
        }
        return bagsFilled;
    }
}
}