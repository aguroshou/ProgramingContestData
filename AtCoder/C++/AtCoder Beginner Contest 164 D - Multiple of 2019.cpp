//AtCoder Beginner Contest 164
//D - Multiple of 2019
#include "bits/stdc++.h"
using namespace std;
typedef long long ll;
int main() {
	ll answer = 0, ModNumber = 0;
	string s;
	ll Mod2019Data[2019] = {};
	cin >> s;
	Mod2019Data[0]++;
	ll Pow10Mod2019 = 1;
	for (int i = s.length() - 1; i >= 0; i--)
	{
		ModNumber = (ModNumber + (s[i] - '0') * Pow10Mod2019) % 2019;
		Pow10Mod2019 = Pow10Mod2019 * 10 % 2019;
		Mod2019Data[ModNumber]++;
	}
	for (int i = 0; i < 2019; i++)
	{
		answer += Mod2019Data[i] * (Mod2019Data[i] - 1) / 2;
	}
	cout << answer << endl;
	return 0;
}