#include <iostream>
using namespace std;

int main(){
    int N, M;
    cin >> N >> M;
    
    int array1[N][M] = { 0 };
    int array2[N][M] = { 0 };
    
    for(int i = 0; i < N; i++)
        for(int j = 0; j < M; j++)
            cin >> array1[i][j];
    
    for(int i = 0; i < N; i++)
        for(int j = 0; j < M; j++)
            cin >> array2[i][j];
    
    for(int i = 0; i < N; i++){
        for(int j = 0; j < M; j++){
            cout << array1[i][j] + array2[i][j] << ' ';
        }
        cout << '\n';
    }
    
    return 0;
}