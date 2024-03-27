#include <string>
#include <vector>
#include <map>

using namespace std;

vector<string> solution(vector<string> players, vector<string> callings) {
    map<string, int> playerList;
    for(int i = 0; i < players.size(); i++){
        playerList[players[i]] = i;
    }
    
    for (int i = 0; i < callings.size(); i++)
	{
		string calling = callings[i];
		int index = playerList[calling];

		string player = players[index - 1];
		players[index - 1] = players[index];
		players[index] = player;

		playerList[calling] = index - 1;
		playerList[player] = index;

	}
    
    return players;
}