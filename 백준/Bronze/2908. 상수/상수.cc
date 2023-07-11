#include <iostream>
using namespace std;

int main() {
    string A, B;
    cin >> A >> B;
    for(int i = 2; i >= 0; i--){
        if(A[i] != B[i]){
            if(A[i] - '0' > B[i] - '0'){
                cout << A[2] << A[1] << A[0];
            }
            else{
                cout << B[2] << B[1] << B[0];
            }
            return 0;
        }
    }
}