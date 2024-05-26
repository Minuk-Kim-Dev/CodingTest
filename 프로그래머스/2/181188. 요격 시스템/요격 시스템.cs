using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] targets) {
        List<(int, int)> targetList = new List<(int, int)>();
        for(int i = 0; i < targets.GetLength(0); i++)
            targetList.Add((targets[i, 0], targets[i, 1]));
        targetList = targetList.OrderBy(t => t.Item1).ToList();
        
        int answer = 0;
        int tail = 0;
        
        foreach((int start, int end) point in targetList)
        {
            if(point.end < tail)
            {
                tail = point.end;
                continue;
            }

            if(point.start >= tail)
            {
                answer++;
                tail = point.end;
            }
        }
        return answer;
    }
}