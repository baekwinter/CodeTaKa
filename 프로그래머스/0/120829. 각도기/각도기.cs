using System;

public class Solution {
    public int solution(int angle) {
        int answer = 0;
        
        if(angle < 90)
        {
            angle = 1;
        }
         else if(angle == 90)
        {
            angle = 2;
        }
         else if(angle < 180)
        {
            angle = 3;
        }
         else if(angle == 180)
        {
            angle = 4;
        }
        return angle;
    }
}