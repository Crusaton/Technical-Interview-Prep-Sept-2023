/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        
        // If the current node is null we know we've reached the end of the tree and can break the loop.
        if(root == null)
        {
            return 0;
        }
        // We recursively add 1 to the max side of the tree.
        // Since we are starting at the very bottom we'd start with 0, add 1 etc. 
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));    }
}