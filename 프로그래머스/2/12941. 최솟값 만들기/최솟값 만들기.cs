using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int answer = 0;

        var sortedA = A.OrderBy(x => x).ToArray();
        var sortedDescB = B.OrderByDescending(x => x).ToArray();

        for(int i = 0; i < sortedA.Length; i++)
        {
            answer += sortedA[i] * sortedDescB[i];
        }
        
        return answer;
    }
}