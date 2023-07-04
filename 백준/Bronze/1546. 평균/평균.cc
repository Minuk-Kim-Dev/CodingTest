#include <iostream>
using namespace std;

int main(){
    int N;
    double max, total = 0;
    cin >> N;
    double arr[N] = {0};
    for(int i = 0; i < N; i++){
        cin >> arr[i];
        if(i == 0){
            max = arr[i];
        }
        else{
            if(max < arr[i])
                max = arr[i];
        }
    }
    for(int i = 0; i < N; i++){
        arr[i] = arr[i] / max * 100;
        total += arr[i];
    }
    cout << total / N;
}