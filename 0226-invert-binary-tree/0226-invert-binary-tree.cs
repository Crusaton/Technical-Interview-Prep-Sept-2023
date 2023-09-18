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
    public TreeNode InvertTree(TreeNode root) {
        
        // If root is null it means we've reached the end of our tree / recursive loop.
        if(root == null)
        {
            return null;
        }
        
        
        // Temp value to not lose the left side value.
        var tmp = root.left;
        
        // Set left equal to right.
        root.left = root.right;
        
        // Set right equal to our temp value (left).
        root.right = tmp;
        
        
        // Recursively loop to flip the left side tree.
        InvertTree(root.left);
        // Recursively loop to flip the right side tree.
        InvertTree(root.right);
        
        return root;
    }
}