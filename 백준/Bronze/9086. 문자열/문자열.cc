#include <iostream>
#include <string>
using namespace std;

int main(){
    int T;
    string s = "";
    cin >> T;
    for(int i = 0; i < T; i++){
        cin >> s;
        for(int j = 0; j < s.length(); j++){
            if(j == 0)
                cout << s[j];
            if(j == s.length() - 1)
                cout << s[j];
        }
        cout << '\n';
    }
}