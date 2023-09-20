/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        // Prev is null so we can set our previous head's next value to null.
        // Curr is our first value so head.
        ListNode prev = null, curr = head;
        
        // While we haven't reached the end of the original list.
        while(curr != null)
        {
            // Save the next value from curr.
            var temp = curr.next;
            // Point curr's next backwards.
            curr.next = prev;
            // Move our previous value up one.
            prev = curr;
            // Move curr up one.
            curr = temp;
        }
        return prev;
    }
}