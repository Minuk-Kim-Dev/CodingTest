#include <iostream>
using namespace std;

int main(){
    int N, M, i, j, k;
    cin >> N >> M;
    int arr[N] = {0};
    for(int a = 0; a < M; a++){
        cin >> i >> j >> k;
        for(int b = i - 1; b < j; b++){
            arr[b] = k;
        }
    }
    for(int i = 0; i < N; i++){
        cout << arr[i] << " ";
    }
}