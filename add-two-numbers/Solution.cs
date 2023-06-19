namespace add_two_numbers
{
    public static class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0); // head of newly generated list
            ListNode curr = head;
            int sum;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0) //carry!=0 for the last node
            {
                sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                carry = sum / 10;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            return head.next;
        }
    }
}