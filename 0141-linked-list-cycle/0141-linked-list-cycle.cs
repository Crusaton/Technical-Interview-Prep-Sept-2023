/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        ListNode slow = head;
        ListNode fast = head;
        
        // If there is no cycle in the linked list eventually fast will break out of the loop. Otherwise eventually fast will be the same node as slow.
        while(fast != null && fast.next != null)
        {
            // fast jumps forward two
            fast = fast.next.next;
            // slow jumps forward one
            slow = slow.next;
            // If they equal eachother we know we have a cycle.
            if(slow == fast)
            {
                return true;
            }
        }
        return false;
    }
}