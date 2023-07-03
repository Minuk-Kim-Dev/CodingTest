#include <iostream>
using namespace std;

int main(){
    int T, a, b;
    cin.tie(NULL);
    cin >> T;
    for(int i = 0; i < T; i++){
        cin >> a >> b;
        cout << a + b << '\n';
    }
}