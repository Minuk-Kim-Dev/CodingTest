using System;
using System.Collections.Generic;

public class Solution
{
    //숙련도 - level
    //if(diff[i] <= level) -> time[i]만큼 시간 소요
    //if(diff[i] > level) -> ((diffs[i] - level) * (times[i] + times[i - 1])) + times[i]
    public int solution(int[] diffs, int[] times, long limit)
    {
        int maxLevel = FindMaxValue(diffs);
        int minLevel = 1;
        int answer = maxLevel;

        while(minLevel <= maxLevel)
        {
            int level = (maxLevel + minLevel) / 2;

            //현재 level로 퍼즐이 해결될 경우, level을 감소시킴
            if (SolvePuzzle(diffs, times, limit, level))
            {
                answer = level;
                maxLevel = level - 1;
            }
            //현재 level로 퍼즐이 해결되지 않을 경우, level을 증가시킴
            else
            {
                minLevel = level + 1;
            }
        }

        return answer;
    }

    //level로 퍼즐이 제한 시간 내에 해결되면 true, 아니면 false
    public bool SolvePuzzle(int[] diffs, int[]times, long limit, int level)
    {
        long timer = 0; 

        for (int i = 0; i < diffs.Length; i++)
        {
            int diff = diffs[i] - level;

            //diff[i] > level
            if (diff > 0)
            {
                int failCount = diffs[i] - level;
                int prevTime = (i > 0) ? times[i - 1] : 0;

                timer += (failCount * (times[i] + prevTime)) + times[i];
            }
            //diff[i] <= level
            else
            {
                timer += times[i];
            }
        }

        if (timer <= limit)
            return true;
        else
            return false;
    }

    public int FindMaxValue(int[] array)
    {
        int max = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }

        return max;
    }
}