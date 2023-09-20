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
        
        int counter = 0;
        ListNode temp = head;
        while(head != null)
        {
            counter++;
            head = head.next;
        }
        
        if(counter % 2 == 0)
        {
            counter = (counter / 2) + 1;
        }
        else
        {
            decimal tempp = counter / 2;
            counter = (int)Math.Round(tempp) + 1;
        }
        for(int i = 1; i < counter; i++)
        {
            temp = temp.next;
        }
        return temp;
    }
}