using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int paintRange = 0;
        for(int i = 0; i < section.Length; i++){
            if(section[i] < paintRange)
                continue;
            
            if(section[i] > paintRange){
                paintRange = section[i] + m - 1;
                answer++;
                continue;
            }
        }
        return answer;
    }
}