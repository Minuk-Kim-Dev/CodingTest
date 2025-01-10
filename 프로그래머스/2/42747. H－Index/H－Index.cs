using System;
using System.Linq;

public class Solution
{
    public int solution(int[] citations)
    {
        var sortedCitations = citations.OrderByDescending(x => x).ToArray();
        int answer = 0;

        for (int i = 0; i < sortedCitations.Length; i++)
        {
            int h = sortedCitations[i];

            if (i + 1 >= h)
            {
                answer = h;
                break;
            }

            int next = i < sortedCitations.Length - 1 ? sortedCitations[i + 1] : 0;

            for (int j = h; j > next; j--)
            {
                if (i + 1 >= j)
                {
                    answer = j;
                    return answer;
                }
            }
        }

        return answer;
    }
}