using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[2];
        int start = 0;
        int end = 0;
        int length = int.MaxValue;
        int sum = sequence[0];
        
        while(start < sequence.Length){
            if(sum < k){
                end++;
                
                if(end >= sequence.Length)
                    break;
                
                sum += sequence[end];
            }
            else if(sum == k){
                int curLength = end - start + 1;
                if(length > curLength){
                    answer[0] = start;
                    answer[1] = end;
                    length = curLength;
                }
                sum -= sequence[start];
                start++;
            }
            else{
                sum -= sequence[start];
                start++;
            }
        }
        
        return answer;
    }
}