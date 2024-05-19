using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        for(int i = 0; i < s.Length; i++){
            answer += GetPassword(s[i], index, skip);
        }
        return answer;
    }
    
    char GetPassword(char start, int index, string skip){
        char password = start;
        
        for(int i = 0; i < index;){
            if(password == 'z')
                password = 'a';
            else
                password = (char)((int)password + 1);
            
            if(!IsSkip(password, skip))
                i++;
        }
        
        return password;
    }
    
    bool IsSkip(char c, string skip){
        for(int i = 0; i < skip.Length; i++){
            if(c == skip[i])
                return true;
        }
        return false;
    }
}