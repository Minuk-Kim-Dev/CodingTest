using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] startPoint = new int[2] {50, 50};
        int[] endPoint = new int[2] {0, 0};
        
        for(int i = 0; i < wallpaper.Length; i++)
        {
            string icons = wallpaper[i];
            for(int j = 0; j < icons.Length; j++)
            {
                if(icons[j] == '#')
                {                 
                    startPoint[0] = startPoint[0] > i ? i : startPoint[0];
                    startPoint[1] = startPoint[1] > j ? j : startPoint[1];
                    endPoint[0] = endPoint[0] < i + 1 ? i + 1 : endPoint[0];
                    endPoint[1] = endPoint[1] < j + 1 ? j + 1 : endPoint[1];
                }
            }
        }
        
        int[] answer = new int[] {startPoint[0], startPoint[1], endPoint[0], endPoint[1]};
        return answer;
    }
}