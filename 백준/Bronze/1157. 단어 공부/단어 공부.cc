#include <iostream>
using namespace std;

int main()
{
	string s;
	cin >> s;
	int count = 0, max = 0, max_index = 0;;
	int c[26] = { 0 };
	
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i] < 97)
            c[s[i] - 65]++;
		else 
            c[s[i] - 97]++;
	}
	
	for (int i = 0; i < 26; i++)
	{
		if (max < c[i])
		{
            count = 1;
			max = c[i];
			max_index = i;
		}
        else if(max == c[i]){
            count++;
        }
	}

	if (count > 1) 
        cout << "?";
	else 
        cout << (char)(max_index + 65);
}