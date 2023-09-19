public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        
        // If our starting point is the desired color we are done.
        if(image[sr][sc] == color)
        {
            return image;
        }
        // Enter DFS loop
        fill(image, sr, sc, image[sr][sc], color);
        
        return image;
        
    }
    public void fill(int[][] image, int sr, int sc, int color, int newColor)
    {
        // If we've hit one of the edges of our matrix, or if the color we are looking at does not match the color we started from we break from the loop
        if(sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color)
        {
            return;
        }
        // Set current pixel to new color
        image[sr][sc] = newColor;
        fill(image, sr + 1, sc, color, newColor);
        fill(image, sr -1, sc, color, newColor);
        fill(image, sr, sc + 1, color, newColor);
        fill(image, sr, sc - 1, color, newColor);

    }
}