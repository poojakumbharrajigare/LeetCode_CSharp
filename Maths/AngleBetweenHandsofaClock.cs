/*
Given two numbers, hour and minutes, return the smaller angle (in degrees) formed between the hour and the minute hand.

Answers within 10-5 of the actual value will be accepted as correct.
*/

public class Solution {
    public double AngleClock(int hour, int minutes) {
        int oneMinAngle = 6; //360/60 (60 mins)
        int oneHourAngle = 30; //360/12 (12 hours)

        if(hour == 12)
            hour = 0;

        double minutesAngleFromHour = (((double)minutes) / 5 - hour) * 30;
        double hourAngle = (double)oneHourAngle/360 * ((double)minutes) * oneMinAngle;

        double angle = Math.Abs(minutesAngleFromHour - hourAngle);

        return angle > 180 ? 360 - angle : angle;
    }
}