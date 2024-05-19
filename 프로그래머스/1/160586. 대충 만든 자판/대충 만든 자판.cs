using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        for(int i = 0; i < targets.Length; i++){
            int sum = 0;
            
            for(int j = 0; j < targets[i].Length; j++){
                int count = ButtonCount(keymap, targets[i][j]);
                
                if(count == -1){
                    sum = -1;
                    break;
                }
                else
                    sum += count;
            }
            
            answer[i] = sum;
        }
        
        return answer;
    }
    
    int ButtonCount(string[] keymap, char target){
        int count = -1;
        
        for(int i = 0; i < keymap.Length; i++){
            for(int j = 0; j < keymap[i].Length; j++){
                if(keymap[i][j] == target){
                    if(count == -1){
                        count = j + 1;
                      continue;
                    }
                
                    if(j < count){
                        count = j + 1;
                        continue;
                   }
                }
            }
        }
        return count;
    }
}