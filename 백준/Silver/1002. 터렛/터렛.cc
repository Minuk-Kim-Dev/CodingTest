#include <iostream>
#include <cmath>
#include <cstdlib>
using namespace std;

struct Point{
    int x, y;
};

double Distance(Point a, Point b){
    double distance;
    distance = sqrt(pow(a.x - b.x, 2) + pow(a.y - b.y, 2));
    return distance;
}

int main(){
    Point a, b;
    int r1, r2;
    double distance;
    int T;
    cin >> T;
    for(int i = 0; i < T; i++){
        cin >> a.x >> a.y >> r1 >> b.x >> b.y >> r2;
        distance = Distance(a, b);
        
        if(a.x == b.x && a.y == b.y && r1 == r2){
            cout << -1 << endl;
        }
        else if(abs(r1 - r2) == distance || r1 + r2 == distance){
            cout << 1 << endl;
        } 
        else if(abs(r1 - r2) < distance && r1 + r2 > distance){
            cout << 2 << endl;
        }
        else{
            cout << 0 << endl;
        }
    }
}