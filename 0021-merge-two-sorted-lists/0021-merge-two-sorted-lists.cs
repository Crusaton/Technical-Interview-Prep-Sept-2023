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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        
        // Initialize two new nodes, head so we keep track of front of list and tail which we can use as our curr
        ListNode head = new();
        ListNode tail = head;
        
        
        // While BOTH of the lists is not null
        while(list1 != null && list2 != null)
        {
            // if list1 is less than list2 we found our next value
            if(list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            // Else list2 is our next value
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            // Move tail forward one.
            tail = tail.next;
        }
        // If list1 isn't null we add it to our list
        if(list1 != null)
        {
            tail.next = list1;
        }
        // If list2 isn't null we add it to our list
        if (list2 != null)
        {
            tail.next = list2;
        }
        
        // Return head.next which would be the first real value in our list.
        return head.next;
    }
}