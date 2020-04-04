//AtCoder Beginner Contest 161
//D - Lunlun Number
#include "bits/stdc++.h"
using namespace std;
typedef long long ll;
int main()
{
	ll k;
	cin >> k;
	ll skipNumber = 1;
	ll lunLunNumberSum = 0;
	ll checkNumber = 0;
	while (lunLunNumberSum < k)
	{
		checkNumber += skipNumber;
		skipNumber = 1;
		string checkNumberString = to_string(checkNumber);
		if (checkNumberString.length() == 1)
		{
			lunLunNumberSum++;
		}
		else
		{
			for (int i = 0; i < checkNumberString.length() - 1; i++)
			{
				if (abs(checkNumberString[i] - checkNumberString[i + 1]) > 1)
				{
					for (int j = i + 1; j < checkNumberString.length() - 1; j++)
					{
						skipNumber *= 10;
					}
					break;
				}
				if (i >= checkNumberString.length() - 2)
				{
					lunLunNumberSum++;
				}
			}
		}
	}
	cout << checkNumber << endl;
	return 0;
}