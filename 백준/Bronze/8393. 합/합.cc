#include <iostream>
using namespace std;

int main(){
    int num;
    cin >> num;
    if(num % 2 == 0) cout << (1 + num) * (num / 2);
    else if(num % 2 == 1) cout << ((1 + num) * (num / 2)) + ((num / 2) + 1);
}