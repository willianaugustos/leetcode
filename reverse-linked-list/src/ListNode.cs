namespace reverse_linked_list;

public record ListNode (int val, ListNode? next=null) {
      public readonly int val = val;
      public readonly ListNode? next = next;
}