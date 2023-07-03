#include <iostream>
using namespace std;

int main(){
    int N, X;
    cin >> N >> X;
    int array[N] = {0};
    for(int i = 0; i < N; i++){
        cin >> array[i];
    }
    for(int i = 0; i < N; i++){
        if(X > array[i])
            cout << array[i] << " ";
    }
}