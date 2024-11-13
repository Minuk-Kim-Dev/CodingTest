using System;
using System.Collections.Generic;

public class Solution
{
    public string[] DFS(string start, Dictionary<string, List<string>> dict)
    {
        List<string> answer = new List<string>();
        Stack<string> stack = new Stack<string>();
        stack.Push(start);

        while(stack.Count > 0)
        {
            string current = stack.Peek();

            if (dict.ContainsKey(current))
            {
                if (dict[current].Count > 0)
                {
                    stack.Push(dict[current][0]);
                    dict[current].RemoveAt(0);

                    if (dict[current].Count == 0)
                    {
                        dict[current].Clear();
                        dict.Remove(current);
                    }
                }
            }
            else
            {
                string pop = stack.Pop();
                answer.Add(pop);
            }
        }

        answer.Reverse();

        return answer.ToArray();
    }

    public string[] solution(string[,] tickets)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < tickets.GetLength(0); i++)
        {
            if(!dict.ContainsKey(tickets[i, 0]))
            {
                dict.Add(tickets[i, 0], new List<string>());
            }

            dict[tickets[i, 0]].Add(tickets[i, 1]);
        }

        foreach(var list in  dict.Values)
        {
            list.Sort();
        }

        string[] answer = DFS("ICN", dict);

        return answer;
    }
}