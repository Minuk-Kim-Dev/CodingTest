using System;
using System.Collections.Generic;

public class Solution
{
    public class Job : IComparable<Job>
    {
        public int number;
        public int requestTime;
        public int requiredTime;

        public Job(int number, int requestTime, int requiredTime)
        {
            this.number = number;
            this.requestTime = requestTime;
            this.requiredTime = requiredTime;
        }

        public int CompareTo(Job other)
        {
            if (this.requiredTime != other.requiredTime)
                return this.requiredTime - other.requiredTime;

            if (this.requestTime != other.requestTime)
                return this.requestTime - other.requestTime;

            return this.number - other.number;
        }
    }

    public class Heap<T> where T : class, IComparable<T>
    {
        public List<T> list = new List<T>();
        public int Count => list.Count;

        public void Add(T item)
        {
            list.Add(item);
            int index = Count - 1;

            while (index > 0)
            {
                int parent = (index - 1) / 2;

                //부모가 우선순위가 더 낮을 경우 스왑 후 반복, 아니면 종료
                if (list[parent].CompareTo(list[index]) > 0)
                {
                    T temp = list[parent];
                    list[parent] = list[index];
                    list[index] = temp;
                    index = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Heap is empty");

            T item = list[0];
            list[0] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            int index = 0;
            while (true)
            {
                int leftNode = index * 2 + 1;
                int rightNode = index * 2 + 2;
                int minIndex = index;

                if (leftNode < Count && list[leftNode].CompareTo(list[minIndex]) < 0)
                    minIndex = leftNode;
                if (rightNode < Count && list[rightNode].CompareTo(list[minIndex]) < 0)
                    minIndex = rightNode;
                if (minIndex != index)
                {
                    T temp = list[index];
                    list[index] = list[minIndex];
                    list[minIndex] = temp;
                    index = minIndex;
                }
                else
                {
                    break;
                }
            }

            return item;
        }
    }

    public int solution(int[,] jobs)
    {
        List<Job> list = new List<Job>();
        Heap<Job> heap = new Heap<Job>();
        Job working = null;
        int time = 0;
        int totalReturnTime = 0;
        int index = 0;

        for(int i = 0; i < jobs.GetLength(0); i++)
        {
            list.Add(new Job(i, jobs[i, 0], jobs[i, 1]));
        }

        list.Sort((a, b) => a.requestTime.CompareTo(b.requestTime));

        while (index < jobs.GetLength(0) || heap.Count > 0)
        {
            //힙이 비어있으면 다음 작업을 수행하는 시간으로 이동
            if (heap.Count == 0 && time < list[index].requestTime)
                time = list[index].requestTime;

            //요청시간이 현재 시간 이하의 작업들 힙에 추가
            while (index < jobs.GetLength(0) && list[index].requestTime <= time)
                heap.Add(list[index++]);

            //힙에서 작업을 하나 꺼내서 수행
            Job current = heap.Pop();
            time += current.requiredTime;
            totalReturnTime += time - current.requestTime;
        }

        return totalReturnTime / jobs.GetLength(0);
    }
}