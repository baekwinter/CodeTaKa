using System;

public class Solution {
    public int solution(int n) {
        int i = 0;
        int answer = 0;
        
        for(i=2; i<=n; i+=2)
           answer  +=i;
        return answer;
    }
}