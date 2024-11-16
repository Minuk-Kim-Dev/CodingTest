using System;
using System.Collections.Generic;

public class Solution
{
    int DFS(int n, ref int[,] computers)
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        int count = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                if (computers[i, j] == 1)
                {
                    stack.Push((i, j));
                    computers[i, j] = 0;
                    computers[j, i] = 0;
                }
            }

            if(stack.Count > 0)
            {
                count++;

                while (stack.Count > 0)
                {
                    var (me, other) = stack.Pop();

                    for (int k = 0; k < n; k++)
                    {
                        if (computers[other,k] == 1)
                        {
                            stack.Push((other, k));
                            computers[other, k] = 0;
                            computers[k, other] = 0;
                        }
                    }
                }
            }
        }

        return count;
    }

    public int solution(int n, int[,] computers)
    {
        int answer = DFS(n, ref computers);

        return answer;
    }
}