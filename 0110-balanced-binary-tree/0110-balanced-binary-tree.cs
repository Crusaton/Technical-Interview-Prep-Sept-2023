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
    
    private bool _result = true;
    
    public bool IsBalanced(TreeNode root) {
        
        DFS(root);
        return _result;
    }
    private int DFS(TreeNode root)
    {
        if(root == null)
        {
            return -1;
        }
        
        int leftDepth = DFS(root.left);
        int rightDepth = DFS(root.right);
        
        _result = _result && (Math.Abs(rightDepth - leftDepth) <= 1);
        
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}