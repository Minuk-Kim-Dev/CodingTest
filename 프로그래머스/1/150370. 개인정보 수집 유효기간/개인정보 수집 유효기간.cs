using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string today, string[] terms, string[] privacies){
        List<int> answer = new List<int>();
        
        for(int i = 0; i < privacies.Length; i++){
            string[] split = privacies[i].Split(' ');
            string date = split[0];
            string code = split[1];
            if(CheckTerms(today, code, date, terms))
                answer.Add(i + 1);
        }
        
        return answer;
    }
    
    //만료됐으면 true, 아니면 false
    bool CheckTerms(string today, string code, string date, string[] terms){
        for(int i = 0; i < terms.Length; i++){
            string[] split = terms[i].Split(' ');
            string docCode = split[0];
            int term = int.Parse(split[1]);
            
            if(code == docCode)
                if(IsExpired(today, date, term))
                    return true;
        }
        return false;
    }
    
    bool IsExpired(string today, string date, int term){
        string[] dateSplit = date.Split('.');
        string[] todaySplit = today.Split('.');
        
        int dateYear = int.Parse(dateSplit[0]);
        int dateMonth = int.Parse(dateSplit[1]);
        int dateDay = int.Parse(dateSplit[2]);
        int todayYear = int.Parse(todaySplit[0]);
        int todayMonth = int.Parse(todaySplit[1]);
        int todayDay = int.Parse(todaySplit[2]);
        
        dateMonth += term;
        dateDay--;
        if(dateDay <= 0){
            dateMonth--;
            dateDay = 28;
            if(dateMonth <= 0){
                dateYear--;
                dateMonth = 12;
            }
        }
        if(dateMonth > 12){
            dateYear += dateMonth / 12;
            if(dateMonth % 12 == 0){
                dateYear--;
                dateMonth = 12;
            }
            else
                dateMonth %= 12;
        }
        
        if(dateYear < todayYear)
            return true;
        else if(dateYear == todayYear){
            if(dateMonth < todayMonth)
                return true;
            else if(dateMonth == todayMonth){
                if(dateDay < todayDay)
                    return true;
            }
        }
        return false;
    }
}