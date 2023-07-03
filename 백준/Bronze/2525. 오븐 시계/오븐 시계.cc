#include <iostream>
using namespace std;

int main(){
    int curH, curM;
    int waitH, waitM;
    cin >> curH >> curM >> waitM;
    curM += waitM;
    waitH = curM / 60;
    curM = curM % 60;
    curH += waitH;
    if(curH >= 24)
        curH -= 24;
    cout << curH << " " << curM;
}