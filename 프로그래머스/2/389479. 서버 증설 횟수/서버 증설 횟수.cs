using System;
using System.Collections.Generic;

public class Solution {
    //(players, m, k) - (시간대 별 이용자 수, 서버가 증설되는 이용자 수 단위, 서버 운영 시간)
    public int solution(int[] players, int m, int k) {
        //(int, int) - (동시에 증설된 서버, 반납하는 시간)
        Queue<(int, int)> servers = new Queue<(int, int)>();
        int serverCount = 0;
        int answer = 0;
        
        for(int i = 0; i < players.Length; i++){
            while (servers.Count > 0 && servers.Peek().Item2 == i) {
                serverCount -= servers.Dequeue().Item1;
            }
            
            int remain = players[i] - (m * serverCount);
            if(remain >= m){
                int need = remain / m;
                servers.Enqueue((need, i + k));
                serverCount += need;
                answer += need;
            }
        }
        
        return answer;
    }
}