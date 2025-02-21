using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    List<int> counts = new List<int>();

    public int solution(int k, int[,] dungeons)
    {
        List<int[]> dungeonList = new List<int[]>();

        for(int i = 0; i < dungeons.GetLength(0); i++)
        {
            int[] dungeon = new int[dungeons.GetLength(1)];

            for(int j = 0; j < dungeons.GetLength(1); j++)
            {
                dungeon[j] = dungeons[i, j];
            }

            dungeonList.Add(dungeon);
        }

        Explore(k, 0, dungeonList);

        counts.Sort((a, b) => b.CompareTo(a));

        return counts[0];
    }

    public void Explore(int health, int count, List<int[]> dungeons)
    {
        if (dungeons.Count == 0)
        {
            counts.Add(count);
            return;
        }

        List<int[]> nextDungeons = new List<int[]>();

        for(int i = 0; i < dungeons.Count; i++)
        {
            nextDungeons = dungeons.ToList();
            int[] dungeon = nextDungeons[i];
            nextDungeons.RemoveAt(i);

            if (health >= dungeon[0])
            {
                Explore(health - dungeon[1], count + 1, nextDungeons);
            }
            else
            {
                counts.Add(count);
            }
        }

        return;
    }
}