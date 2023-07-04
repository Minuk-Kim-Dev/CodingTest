#include <iostream>
using namespace std;

int main(){
    int arr[10] = {0};
    int n, result = 0;
    for(int i = 0; i < 10; i++){
        cin >> n;
        arr[i] = n % 42;
    }
    n = 0;
    for(int i = 0; i < 10; i++){
        for(int j = i + 1; j < 10; j++){
            if(arr[i] == arr[j])
                n++;
        }
        if(n == 0)
            result++;
        n = 0;
    }
    cout << result;
}