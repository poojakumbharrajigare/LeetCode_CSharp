/*
Given the coordinates of two rectilinear rectangles in a 2D plane, return the total area covered by the two rectangles.

The first rectangle is defined by its bottom-left corner (ax1, ay1) and its top-right corner (ax2, ay2).

The second rectangle is defined by its bottom-left corner (bx1, by1) and its top-right corner (bx2, by2).
*/

public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int commonArea = 0;
        bool isNotOverlap = ax1 > bx2 || bx1 > ax2 || ay1 > by2 || by1 > ay2;
        if(!isNotOverlap)
        {
            int height = Math.Min(ay2, by2) - Math.Max(ay1, by1);
            int width = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
            
            commonArea = height * width;
        }

        int area1 = Math.Abs(ay2 - ay1) * Math.Abs(ax2 - ax1);
        int area2 = Math.Abs(by2 - by1) * Math.Abs(bx2 - bx1);

        return area1 + area2 - commonArea;
    }
}