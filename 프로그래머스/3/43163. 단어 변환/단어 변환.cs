using System;
using System.Collections.Generic;

public class Solution
{
    int BFS(string begin, string target, string[] words)
    {
        Queue<(string, int)> queue = new Queue<(string, int)> ();
        queue.Enqueue((begin, 0));
        List<string> visited = new List<string>();

        while(queue.Count > 0)
        {
            var (word, depth) = queue.Dequeue();

            if (word == target)
                return depth;

            foreach(var next in words)
            {
                if(!visited.Contains(next) && CanChange(word, next))
                {
                    queue.Enqueue((next, depth + 1));
                    visited.Add(next);
                }
            }
        }

        return 0;
    }

    bool CanChange(string now, string next)
    {
        int count = 0;

        for(int i = 0; i < now.Length; i++)
        {
            if (now[i] != next[i])
                count++;

            if(count > 1)
            {
                return false;
            }
        }

        return true;
    }

    public int solution(string begin, string target, string[] words)
    {
        int answer = BFS(begin, target, words);

        return answer;
    }
}
