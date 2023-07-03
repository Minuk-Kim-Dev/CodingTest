#include <iostream>
using namespace std;

int main(){
    int max, index;
    int arr[9] = {0};
    for(int i = 0; i < 9; i++){
        cin >> arr[i];
        if(i == 0){
            max = arr[i];
            index = i + 1;
        }
        else{
            if(max < arr[i]){
                max = arr[i];
                index = i + 1;
            }
        }
    }
    cout << max << '\n' << index;
}