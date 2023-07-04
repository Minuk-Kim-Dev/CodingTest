#include <iostream>
using namespace std;

int main(){
    int stu[30] = {0};
    int id;
    for(int i = 0; i < 30; i++){
        cin >> id;
        stu[id - 1] = 1;
    }
    for(int i = 0; i < 30; i++){
        if(stu[i] == 0)
            cout << i + 1 << '\n';
    }
}