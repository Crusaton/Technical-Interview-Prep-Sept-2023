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
        
        ListNode walk = head;
        ListNode run = head;
        
        while(run != null && run.next != null)
        {
            run = run.next.next;
            walk = walk.next;
            if(run == walk)
            {
                return true;
            }
        }
        return false;
    }
}