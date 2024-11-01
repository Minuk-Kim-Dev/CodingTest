using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public string solution(int[] numbers)
    {
        string[] nums = Array.ConvertAll(numbers, num => num.ToString());

        Array.Sort(nums, (x, y) => (y + x).CompareTo(x + y));

        if (nums[0] == "0")
            return "0";

        StringBuilder answer = new StringBuilder();
        foreach (var num in nums)
        {
            answer.Append(num);
        }

        return answer.ToString();
    }
}