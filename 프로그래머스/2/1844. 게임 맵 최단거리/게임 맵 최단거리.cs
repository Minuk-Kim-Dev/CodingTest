using System;
using System.Collections.Generic;

class Solution
{
    int BFS(int[,] maps)
    {
        int w = maps.GetLength(0);
        int h = maps.GetLength(1);

        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((0, 0, 1));

        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };

        while (queue.Count > 0)
        {
            var (x, y, distance) = queue.Dequeue();

            if(x == w - 1 && y == h - 1)
                return distance;

            for(int i = 0; i < 4; i++)
            {
                int nextX = x + dx[i];
                int nextY = y + dy[i];

                if(nextX >= 0 && nextX < w && nextY >= 0 && nextY < h && maps[nextX, nextY] == 1)
                {
                    maps[nextX, nextY] = 0;
                    queue.Enqueue((nextX, nextY, distance + 1));
                }
            }
        }

        return -1;
    }

    public int solution(int[,] maps)
    {
        int answer = BFS(maps);
        return answer;
    }
}