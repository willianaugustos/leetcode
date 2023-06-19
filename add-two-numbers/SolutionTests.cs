namespace add_two_numbers;

public class SolutionTests
{
    [Theory]
    [InlineData(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8})]
    [InlineData(new[] {0}, new[] {0}, new[] {0})]
    [InlineData(new[] {9, 9, 9, 9, 9, 9, 9}, new[] {9, 9, 9, 9}, new[] {8, 9, 9, 9, 0, 0, 0, 1})]
    [InlineData(new[] {9}, new [] {1, 9, 9, 9, 9, 9, 9, 9, 9, 9}, new[] {0,0,0,0,0,0,0,0,0,0,1})]
    [InlineData(new[]{1,1,1,1,1,1,1,1,1,1,1}, new[]{1,1,1,1,1,1,1,1,1,1,1}, new[]{2,2,2,2,2,2,2,2,2,2,2})]
    [InlineData(new[]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1}, new[] {5,6,4}, new[] {6,6,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1})]
    public void TestCases(int[] l1, int[] l2, int[] expected) =>
        Assert.Equal(expected, Solution.AddTwoNumbers(CreateListNode(l1), CreateListNode(l2)).ToArray());

    private static ListNode CreateListNode(int[] nums)
    {
        var head = new ListNode(nums[0]);
        var current = head;
        for (var i = 1; i < nums.Length; i++)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;
        }
        return head;
    }
}