#include <iostream>

using namespace std;

int main(){
    int fiboOutput[41] = {0, 1, 1};
    for(int i = 3; i < sizeof(fiboOutput)/sizeof(int); i++){
        fiboOutput[i] = fiboOutput[i - 1] + fiboOutput[i - 2];
    }
    
    int T = 0, N = 0;
    cin >> T;
    for(int i = 0; i < T; i++){
        cin >> N;
        if(N == 0) cout << 1 << " " << 0 << endl;
        else if(N == 1) cout << 0 << " " << 1 << endl;
        else cout << fiboOutput[N - 1] << " " << fiboOutput[N] << endl;
    }
}
