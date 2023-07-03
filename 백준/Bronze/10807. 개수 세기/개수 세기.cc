#include <iostream>
using namespace std;

int main(){
    int N, v, cnt = 0;
    cin >> N;
    int array[N] = { 0 };
    for(int i = 0; i < N; i++){
        cin >> array[i];
    }
    cin >> v;
    for(int i = 0; i < N; i++){
        if(array[i] == v)
            cnt++;
    }
    cout << cnt;
}