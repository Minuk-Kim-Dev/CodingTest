using System;

public class Solution
{
    static int count = 0;

    void DFS(int[] numbers, int index, int sum, int target)
    {
        if(numbers.Length - 1 == index)
        {
            if (sum == target)
                count++;

            return;
        }
        else
        {
            int plusSum = sum + numbers[index + 1];
            DFS(numbers, index + 1, plusSum, target);
            int minusSum = sum - numbers[index + 1];
            DFS(numbers, index + 1, minusSum, target);
        }
    }

    public int solution(int[] numbers, int target)
    {
        int[] newNumbers = new int[numbers.Length + 1];
        newNumbers[0] = 0;

        for(int i = 1; i < newNumbers.Length; i++)
        {
            newNumbers[i] = numbers[i - 1];
        }

        DFS(newNumbers, 0, 0, target);

        return count;
    }
}