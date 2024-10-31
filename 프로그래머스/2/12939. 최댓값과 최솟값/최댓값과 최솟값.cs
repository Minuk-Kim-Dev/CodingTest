using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        string[] split = s.Split(' ');
        List<int> nums = new List<int>();

        foreach(string num in split)
        {
            nums.Add(int.Parse(num));
        }

        nums.Sort();

        int min = nums[0];
        int max = nums[nums.Count - 1];

        string answer = $"{min.ToString()} {max.ToString()}";
        return answer;
    }
}