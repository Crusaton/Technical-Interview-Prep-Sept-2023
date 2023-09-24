public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        
        
        // Sort the 2D array by the first element of each of the child arrays.
        Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
        
        // Iterate through the 2D array.
        for(int i = 0; i < intervals.Length - 1; i++)
        {
            // If the end time value of the left side is greater than the start time value of the right side we know they can't attend both meetings. 
            if(intervals[i][1] > intervals[i + 1][0])
            {
                return false;
            }
        }
        return true;
    }
}