using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[,] clothes)
    {
        int answer = 1;
        Dictionary<string, int> clothesDict = new Dictionary<string, int>();

        //의상 종류 개수 세기
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];

            if (!clothesDict.ContainsKey(type))
                clothesDict.Add(type, 0);

            clothesDict[type]++;
        }

        //모든 종류의 의상 경우의 수를 곱하고 아무것도 안 입는 경우 제외
        foreach (var count in clothesDict.Values)
        {
            answer *= (count + 1);
        }

        return answer - 1;
    }
}
