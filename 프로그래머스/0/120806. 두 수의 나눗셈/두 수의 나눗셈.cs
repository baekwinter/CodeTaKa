using System;

public class Solution {
    public int solution(int num1, int num2) {
        
        int answer = 0;
        float answer1;
        
        answer1 = ((float)num1 / (float)num2) * 1000;
        answer = (int)answer1;
            
        return answer;
    }
}