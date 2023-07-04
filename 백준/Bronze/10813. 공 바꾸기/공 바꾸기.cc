#include <iostream>
using namespace std;

int main(){
    int N, M, i, j, temp;
    cin >> N >> M;
    int arr[N];
    for(int a = 0; a < N; a++){
        arr[a] = a + 1;
    }
    for(int a = 0; a < M; a++){
        cin >> i >> j;
        temp = arr[i - 1];
        arr[i - 1] = arr[j - 1];
        arr[j - 1] = temp;
    }
    for(int a = 0; a < N; a++){
        cout << arr[a] << " ";
    }
}