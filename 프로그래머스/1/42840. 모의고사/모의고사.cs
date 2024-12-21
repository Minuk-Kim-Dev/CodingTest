using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] firstSolve = { 1, 2, 3, 4, 5 };
        int[] secondSolve = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] thirdSolve = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] scores = new int[3];

        for(int i = 0; i < answers.Length; i++)
        {
            if (firstSolve[i % firstSolve.Length] == answers[i])
                scores[0]++;

            if(secondSolve[i % secondSolve.Length] == answers[i])
                scores[1]++;

            if(thirdSolve[i % thirdSolve.Length] == answers[i])
                scores[2]++;
        }

        return FindWinner(scores);
    }

    int[] FindWinner(int[] scores)
    {
        int max = FindMax(scores);
        List<int> winners = new List<int>();

        for(int i = 0; i < scores.Length; i++)
        {
            if(max == scores[i])
                winners.Add(i + 1);
        }

        return winners.ToArray();
    }

    int FindMax(int[] values)
    {
        int max = int.MinValue;

        for(int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
                max = values[i];
        }

        return max;
    }
}