#include <iostream>
#include <string>
using namespace std;

int main(){
    int T, result = 0;;
    string s;
    cin >> T >> s;
    for(int i = 0; i < T; i++){
        result += s[i] - '0';
    }
    cout << result;
}