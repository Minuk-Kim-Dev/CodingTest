#include <iostream>
using namespace std;

int main(){
    int h, m;
    cin >> h >> m;
    if(m < 45){
        if(h == 0) h = 23;
        else h = h - 1;
        m += 60;
    }
    cout << h << " " << m - 45;
}