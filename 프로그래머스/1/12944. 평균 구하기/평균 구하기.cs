public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int a = 0;
        for(int i = 0; i < arr.Length; i++){
            
            a += arr[i];     
        }  
        
        answer = (double)a / arr.Length;
        
        return answer;
    }
}
