/*
같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다. 
같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다. 
모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.  
*/
#include <iostream>
using namespace std;

int main(){
    int dice[3];
    int diceNum[6] = { 0 };
    int highest;
    cin >> dice[0] >> dice[1] >> dice[2];
    for(int i = 0; i < 3; i++){
        diceNum[dice[i] - 1]++;
    }
    for(int i = 0; i < 6; i++){
        if(diceNum[i] == 3){
            cout << 10000 + ((i + 1)*1000);
            return 0;
        }
        else if(diceNum[i] == 2){
            cout << 1000 + ((i + 1)*100);
            return 0;
        }
        else if(diceNum[i] == 1)
            highest = i + 1;
    }
    cout << highest * 100;
}