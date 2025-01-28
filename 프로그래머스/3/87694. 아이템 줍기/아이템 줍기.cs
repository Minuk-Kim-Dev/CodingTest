using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY)
    {
        int[,] map = new int[102, 102];
        characterX *= 2;
        characterY *= 2;
        itemX *= 2;
        itemY *= 2;
        int answer = 0;

        for (int i = 0; i < rectangle.GetLength(0); i++)
        {
            int leftBottomX = rectangle[i, 0] * 2;
            int leftBottomY = rectangle[i, 1] * 2;
            int rightTopX = rectangle[i, 2] * 2;
            int rightTopY = rectangle[i, 3] * 2;

            for(int y = leftBottomY; y <= rightTopY; y++)
            {
                for(int x = leftBottomX; x <= rightTopX; x++)
                {
                    if (x == leftBottomX || x == rightTopX || y == leftBottomY || y == rightTopY)
                    {
                        if (map[y, x] != -1)
                        {
                            map[y, x] = 1;
                            continue;
                        }
                    }
                    else
                        map[y, x] = -1;
                }
            }
        }

        var queue = new Queue<(int x, int y, int distance)>();
        int[] dirX = new int[4] { -1, 1, 0, 0 };
        int[] dirY = new int[4] { 0, 0, -1, 1 };
        queue.Enqueue((characterX, characterY, 0));

        while(queue.Count > 0)
        {
            var pos = queue.Dequeue();
            map[pos.y, pos.x] = -1;

            for (int i = 0; i < 4; i++)
            {
                int nextX = pos.x + dirX[i];
                int nextY = pos.y + dirY[i];
                int nextDistance = pos.distance + 1;

                if (nextX == itemX && nextY == itemY)
                {
                    answer = nextDistance / 2;
                    queue.Clear();
                    break;
                }

                if (map[nextY, nextX] == 1)
                    queue.Enqueue((nextX, nextY, nextDistance));
            }
        }

        return answer;
    }
}