using System;
using System.Collections.Generic;

public class Solution
{
    public class DualPriorityQueue
    {
        public List<int> list = new List<int>();

        public void Command(string command)
        {
            string[] split = command.Split(' ');

            switch (split[0])
            {
                //Enqueue
                case "I":
                    Enqueue(int.Parse(split[1]));
                    break;

                //Dequeue
                case "D":
                    Dequeue(int.Parse(split[1]));
                    break;
            }
        }

        public void Enqueue(int item)
        {
            list.Add(item);
            list.Sort((a, b) => b.CompareTo(a));
        }

        public int Dequeue(int command)
        {
            if (list.Count == 0)
                return -1;

            int item = 0;

            switch (command)
            {
                //최댓값(list[0]) 삭제
                case 1:
                    item = list[0];
                    list.RemoveAt(0);
                    break;

                //최솟값(list[list.Count - 1]) 삭제
                case -1:
                    item = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    break;
            }

            return item;
        }

        public int[] Peek()
        {
            int[] items = new int[2];

            if(list.Count > 0)
            {
                items[0] = list[0];
                items[1] = list[list.Count - 1];
            }
            else
            {
                items[0] = 0;
                items[1] = 0;
            }

            return items;
        }
    }

    public int[] solution(string[] operations)
    {
        DualPriorityQueue queue = new DualPriorityQueue();

        for(int i = 0; i < operations.Length; i++)
        {
            queue.Command(operations[i]);
        }

        int[] answer = queue.Peek();
        return answer;
    }
}