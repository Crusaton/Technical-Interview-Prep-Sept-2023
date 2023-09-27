public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        
        // If the starting point is already the color we want to make it, we're done.
        if(image[sr][sc] == color)
        {
            return image;
        }
        // Begin our DFS loop.
        fill(image, sr, sc, image[sr][sc], color);
        
        return image;
    }
    
    public void fill(int[][] image, int sr, int sc, int color, int newColor)
    {
        // If the row is less than 0 or greater than the Length we are outside the bounds of the image so we stop
        // If the column is less than 0 or greater than the Length of the row, we are outside the bounds of the image so we stop.
        // If the image pixel we are at is not the same color as the one we are changing we ignore it.
        if(sr < 0  || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color)
        {
            return;
        }
        // Set the pixel color to the new color.
        image[sr][sc] = newColor;
        // Recursively call the method increasing row index by one.
        fill(image, sr + 1, sc, color, newColor);
        // Recursively call the method decreasing row index by one.
        fill(image, sr - 1, sc, color, newColor);
        // Recursively call the method increasing the column index by one.
        fill(image, sr, sc + 1, color, newColor);
        // Recurisvely call the method decreasing the column index by one.
        fill(image, sr, sc - 1, color, newColor);
    }
}