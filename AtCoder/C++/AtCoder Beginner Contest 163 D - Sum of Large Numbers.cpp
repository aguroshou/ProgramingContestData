//AtCoder Beginner Contest 163
//D - Sum of Large Numbers
#include "bits/stdc++.h"
using namespace std;
typedef long long ll;

int main(int argc, char* argv[]) {
	ll n, k, sum = 0;
	cin >> n >> k;
	ll NumberSumsFromLeft[200005] = {};
	ll NumberSumsFromRight[200005] = {};
	ll mod = 1000000007;
	for (ll i = 0; i <= n; i++)
	{
		sum += i;
		sum %= mod;
		NumberSumsFromLeft[i] = sum;
	}
	sum = 0;
	for (ll i = n; i >= 0; i--)
	{
		sum += i;
		NumberSumsFromRight[n - i] = sum;
		sum %= mod;
	}
	sum = 0;
	for (ll i = k - 1; i <= n; i++)
	{
		sum -= NumberSumsFromLeft[i];
		if (sum < 0)
		{
			sum += mod;
		}
		sum += NumberSumsFromRight[i] + 1;
		sum %= mod;
	}
	cout << sum << endl;
	return 0;
}