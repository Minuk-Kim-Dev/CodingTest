using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[,] plans) {
        List<string> answer = new List<string>();
        
        //시작 시간을 기준으로 오름차순 정렬
        List<(string, int, int)> sortedPlans = new List<(string, int, int)>();
        for(int i = 0; i < plans.GetLength(0); i++){
            string[] split = plans[i, 1].Split(':');
            int start = (int.Parse(split[0]) * 60) + int.Parse(split[1]);
            int playtime = int.Parse(plans[i, 2]);
            sortedPlans.Add((plans[i, 0], start, playtime));
        }
        sortedPlans = sortedPlans.OrderBy(o => o.Item2).ToList();
        
        //완료하지 못하고 다음 과제로 넘어갈 경우 스택에 저장
        Stack<(string, int)> temp = new Stack<(string, int)>();
        
        for(int i = 0; i < sortedPlans.Count - 1; i++){
            string name = sortedPlans[i].Item1;
            int curTime = sortedPlans[i].Item2;
            int finTime = sortedPlans[i].Item2 + sortedPlans[i].Item3;
                
            int remainTime = sortedPlans[i + 1].Item2 - finTime;
            
            if(remainTime < 0){
                temp.Push((name, -remainTime));
            }
            else{
                answer.Add(sortedPlans[i].Item1);
                if(remainTime > 0){
                    while(remainTime > 0 && temp.Count > 0){
                        var remainWork = temp.Pop();
                        
                        if(remainTime >= remainWork.Item2){
                            remainTime -= remainWork.Item2;
                            answer.Add(remainWork.Item1);
                        }
                        else{
                            var updateWork = (remainWork.Item1, remainWork.Item2 - remainTime);
                            temp.Push(updateWork);
                            remainTime = 0;
                        }
                    }
                }
            }
        }
        answer.Add(sortedPlans[sortedPlans.Count - 1].Item1);
        
        while(temp.Count > 0)
            answer.Add(temp.Pop().Item1);
        
        return answer.ToArray();
    }
}