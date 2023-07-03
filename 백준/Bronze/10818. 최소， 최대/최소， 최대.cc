#include <iostream>
using namespace std;

int main(){
    int N, min, max;
    cin >> N;
    int array[N] = {0};
    for(int i = 0; i < N; i++){
        cin >> array[i];
        if(i == 0){
            min = array[i];
            max = array[i];
        }
        else{
            if(min > array[i])
                min = array[i];
            else if(max < array[i])
                max = array[i];
        }
    }
    cout << min << " " << max;
}