using System;
using System.Collections.Generic;

public class Solution
{
    public class Process
    {
        public int priority;
        public int location;

        public Process(int priority, int location)
        {
            this.priority = priority;
            this.location = location;
        }
    }

    public int solution(int[] priorities, int location)
    {
        Queue<Process> queue = new Queue<Process>();
        int answer = 1;

        for (int i = 0; i < priorities.Length; i++)
        {
            Process process = new Process(priorities[i], i);
            queue.Enqueue(process);
        }

        Array.Sort(priorities);
        Array.Reverse(priorities);

        int index = 0;
        while(index < priorities.Length && queue.Count > 0)
        {
            Process process = queue.Dequeue();

            if (priorities[index] == process.priority)
            {
                if (process.location == location)
                    return answer;
                else
                {
                    answer++;
                    index++;
                }
            }
            else
            {
                queue.Enqueue(process);
            }
        }

        return answer;
    }
}