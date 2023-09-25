using reverse_linked_list;
namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[]{5,4,3,2,1}, new int[]{1,2,3,4,5})]
    [InlineData(new int[]{9,7,5}, new int[]{5,7,9})]
    [InlineData(new int[]{2,3}, new int[]{3,2})]
    public void TestCase1(int[] input, int[] expected)
    {
        var head = CreateListNode(input);
        int[] reversed = Solution.ReverseList(head).ToArray();
        Assert.True(reversed.SequenceEqual(expected));
    }

    [Fact]
    public void TestCase2()
    {
        int[] expected = Array.Empty<int>();
        var input = null as ListNode;
        var reversed = Solution.ReverseList(input);
        Assert.True(reversed is null);
    }

    private static ListNode? CreateListNode(int[] ints)
    {
        if (ints.Length==0)
        return null;

        ListNode? head = null;
        for (int i = ints.Length-1; i >= 0; i--)
        {
            var newElement = new ListNode(ints[i], head);
            head = newElement;
        }
        return head;
    }
}


public static class LinkNodeExtensions
{
    public static int[] ToArray(this ListNode head)
    {
        var result = new List<int>() {head.val};
        var e = head.next;
        if (e==null)
            return result.ToArray();

        while (e !=null)
        {
            result.Add(e.val);
            e = e.next;
        }
        return result.ToArray();
    }
}