using System;

public class Solution
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            int price = prices[i];
            int time = 0;

            for(int j = i + 1; j < prices.Length; j++)
            {
                time++;

                if (prices[j] < price)
                    break;
            }

            answer[i] = time;
        }

        return answer;
    }
}