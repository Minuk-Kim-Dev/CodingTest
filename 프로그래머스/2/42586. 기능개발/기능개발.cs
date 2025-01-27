using System;
using System.Collections.Generic;

public class Solution
{
    class Function
    {
        public int progress;
        public int speed;

        public Function(int progress, int speed)
        {
            this.progress = progress;
            this.speed = speed;
        }
    }

    public int[] solution(int[] progresses, int[] speeds)
    {
        Queue<Function> queue = new Queue<Function>();
        List<int> answer = new List<int>();

        for(int i = 0; i < progresses.Length; i++)
        {
            Function func = new Function(progresses[i], speeds[i]);
            queue.Enqueue(func);
        }

        while(queue.Count > 0)
        {
            bool release = true;
            int queueCount = queue.Count;
            int releaseCount = 0;

            for(int i = 0; i < queueCount; i++)
            {
                Function func = queue.Dequeue();
                func.progress += func.speed;

                if (func.progress < 100)
                    release = false;

                if (release == true && func.progress >= 100)
                    releaseCount++;
                else
                    queue.Enqueue(func);
            }

            if(releaseCount > 0)
                answer.Add(releaseCount);
        }

        return answer.ToArray();
    }
}