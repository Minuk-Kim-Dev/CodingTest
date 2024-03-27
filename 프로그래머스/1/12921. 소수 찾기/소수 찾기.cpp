#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    
    vector<bool> check(n + 1, true);
    
    for(int i = 2; i <= n; i++)
    {
        if(check[i] == true)
        {
            for(int j = 2; j * i <= n; j++)
            {
                check[j * i] = false;
            }
            answer++;
        }
    }
    
    return answer;
}