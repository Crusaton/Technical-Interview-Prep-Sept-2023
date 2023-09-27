public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        if(image[sr][sc] == color)
        {
            return image;
        }
        fill(image, sr, sc, image[sr][sc], color);
        
        return image;
    }
    
    public void fill(int[][] image, int sr, int sc, int color, int newColor)
    {
        if(sr < 0  || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color)
        {
            return;
        }
        image[sr][sc] = newColor;
        fill(image, sr + 1, sc, color, newColor);
        fill(image, sr - 1, sc, color, newColor);
        fill(image, sr, sc + 1, color, newColor);
        fill(image, sr, sc - 1, color, newColor);
    }
}