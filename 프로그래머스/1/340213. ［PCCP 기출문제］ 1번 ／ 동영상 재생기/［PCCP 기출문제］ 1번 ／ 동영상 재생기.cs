using System;

public class Solution
{
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        int result = RunCommands(TimeToSeconds(video_len), TimeToSeconds(pos), TimeToSeconds(op_start), TimeToSeconds(op_end), commands);
        string answer = SecondsToTime(result);
        return answer;
    }

    public int RunCommands(int video_len, int pos, int op_start, int op_end, string[] commands)
    {
        for(int i = 0; i < commands.Length; i++)
        {
            if (pos >= op_start && pos <= op_end)
                pos = op_end;

            pos = RunCommand(video_len, pos, commands[i]);

            if (pos >= op_start && pos <= op_end)
                pos = op_end;
        }

        return pos;
    }

    public int RunCommand(int video_len, int pos, string command)
    {
        switch (command)
        {
            case "prev":
                pos = Math.Max(pos - 10, 0);
                break;
            case "next":
                pos = Math.Min(pos + 10, video_len);
                break;
        }

        return pos;
    }

    public int TimeToSeconds(string time)
    {
        string[] split = time.Split(':');
        string min = split[0];
        string sec = split[1];

        return (int.Parse(min) * 60) + int.Parse(sec);
    }

    public string SecondsToTime(int seconds)
    {
        int min = seconds / 60;
        int sec = seconds % 60;

        return $"{min.ToString("D2")}:{sec.ToString("D2")}";
    }
}