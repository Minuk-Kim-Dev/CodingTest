public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        var split = s.Split(' ');

        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length > 0)
            {
                string newWord = char.ToUpper(split[i][0]) + split[i].Substring(1).ToLower();
                answer += newWord;
            }
            else
            {
                answer += split[i];
            }

            if (i < split.Length - 1)
                answer += " ";
        }

        return answer;
    }
}