#include <iostream>

using namespace std;

int main(){
    string name, grade;
    double point, score;
    
    double totalPoint = 0;
    double totalScore = 0;
    double avg;
    
    for(int i = 0; i < 20; i++){
        cin >> name >> point >> grade;
        
        if(grade == "P")
            continue;
        
        totalPoint += point;
        if(grade == "F")
            continue;
        
        switch(grade[0]){
            case 'A':
                score = 4.0;
                break;
            case 'B':
                score = 3.0;
                break;
            case 'C':
                score = 2.0;
                break;
            case 'D':
                score = 1.0;
                break;
        }
        
        if(grade[1] == '+')
            score += 0.5;
        
        totalScore += point * score;
    }
    
    avg = totalScore / totalPoint;
    cout << avg;
    
    return 0;
}