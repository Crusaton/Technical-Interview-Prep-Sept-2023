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
    public ListNode MiddleNode(ListNode head) {
        
        ListNode slow = head;
        ListNode fast = head;
        
        // Similar answer to the linked list cycle question, but since we can expect to not have a cycle in this list we can reuse the logic to get the fast node to the end. Since the fast node is skipping 2 ahead by the time it ends, the slow should be at the mid point.
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
}