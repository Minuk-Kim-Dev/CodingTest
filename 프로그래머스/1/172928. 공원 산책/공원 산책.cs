using System;
using System.Text;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        
        for(int i = 0; i < routes.Length; i++){
            answer = GetPos(park);
            string[] split = routes[i].Split(' ');
            park = GetOrder(park, answer, split[0], int.Parse(split[1]));
        }
        answer = GetPos(park);
        
        return answer;
    }
    
    string[] GetOrder(string[] park, int[] pos, string dir, int range){
        int count = 0;
        StringBuilder[] sb = new StringBuilder[park.Length];
        for (int i = 0; i < park.Length; i++)
            sb[i] = new StringBuilder(park[i]);
        
        switch(dir){
            case "N":
                for(int i = pos[0]; count < range; i--){
                    if(i - 1 < 0){
                        return park;
                        break;
                    }
                        
                    
                    if(park[i - 1][pos[1]] == 'X'){
                        return park;
                        break;
                    }
                    
                    sb[i - 1][pos[1]] = 'S';
                    sb[i][pos[1]] = 'O';
                    count++;
                }
                break;
            case "S":
                for(int i = pos[0]; count < range; i++){
                    if(i + 1 >= park.Length){
                        return park;
                        break;
                    }
                    
                    if(park[i + 1][pos[1]] == 'X'){
                        return park;
                        break;
                    }
                    
                    sb[i + 1][pos[1]] = 'S';
                    sb[i][pos[1]] = 'O';
                    count++;
                }
                break;
            case "W":
                for(int i = pos[1]; count < range; i--){
                    if(i - 1 < 0){
                        return park;
                        break;
                    }
                    
                    if(park[pos[0]][i - 1] == 'X'){
                        return park;
                        break;
                    }
                    
                    sb[pos[0]][i - 1] = 'S';
                    sb[pos[0]][i] = 'O';
                    count++;
                }
                break;
            case "E":
                for(int i = pos[1]; count < range; i++){
                    if(i + 1 >= park[pos[0]].Length){
                        return park;
                        break;
                    }
                    
                    if(park[pos[0]][i + 1] == 'X'){
                        return park;
                        break;
                    }
                    
                    sb[pos[0]][i + 1] = 'S';
                    sb[pos[0]][i] = 'O';
                    count++;
                }
                break;
        }
        
        for (int i = 0; i < park.Length; i++)
            park[i] = sb[i].ToString();
        
        return park;
    }
    
    int[] GetPos(string[] park){
        int[] pos = new int[2];
        for(int i = 0; i < park.Length; i++){
            for(int j = 0; j < park[i].Length; j++){
                if(park[i][j] == 'S'){
                    pos[0] = i;
                    pos[1] = j;
                    continue;
                }
            }
        }
        return pos;
    }
}