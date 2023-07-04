#include <iostream>
using namespace std;

void reverse(int* arr, int start, int end){
    int temp[end - start + 1] = {0};
    int index = 0;
    for(int i = end - 1; i >= start - 1; i--){
        temp[index++] = arr[i];
    }
    index = 0;
    for(int i = start - 1; i < end; i++){
        arr[i] = temp[index++]; 
    }
}

int main(){
    int N, M, a, b;
    cin >> N >> M;
    int arr[N] = {0};
    for(int i = 0; i < N; i++){
        arr[i] = i + 1;
    }
    for(int i = 0; i < M; i++){
        cin >> a >> b;
        reverse(arr, a , b);
    }
    for(int i = 0; i < N; i++){
        cout << arr[i] << " ";
    }
}