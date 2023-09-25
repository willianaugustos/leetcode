namespace reverse_linked_list;

public static class Solution {
    public static ListNode? ReverseList(ListNode? head) {
        if (head?.next is null)
        return head;

        var l = new ListNode(head.val, null);
        var e=head.next;
        while (e != null)
        {
            l = new ListNode(e.val, l);
            e = e.next;
        }
        return l;
    }
}