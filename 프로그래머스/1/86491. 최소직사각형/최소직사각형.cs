using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int weight = 0, height = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            weight = Math.Max(weight, Math.Max(sizes[i, 0], sizes[i, 1]));
            height = Math.Max(height, Math.Min(sizes[i, 0], sizes[i, 1]));
        }

        int answer = weight * height;
        return answer;
    }
}