//킹 1개, 퀸 1개, 룩 2개, 비숍 2개, 나이트 2개, 폰 8개
#include <iostream>
using namespace std;

int main(){
    int normal[6] = {1, 1, 2, 2, 2, 8};
    int input[6] = {0};
    int result[6] = {0};
    for(int i = 0; i < sizeof(input)/sizeof(int); i++){
        cin >> input[i];
        result[i] = normal[i] - input[i];
        cout << result[i] << " ";
    }
}