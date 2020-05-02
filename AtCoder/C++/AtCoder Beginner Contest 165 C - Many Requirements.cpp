//AtCoder Beginner Contest 165
//C - Many Requirements
#include "bits/stdc++.h"
using namespace std;
typedef long long ll;
ll n, m, q;
ll a[51] = {}, b[51] = {}, c[51] = {}, d[51] = {};
ll answer = 0;
void RecursiveFunction(ll Iteration, ll MaxA, vector<ll> A)
{
	if (Iteration == n + 1)
	{
		ll SumDi = 0;
		for (ll i = 1; i <= q; i++)
		{
			if (A[b[i]] - A[a[i]] == c[i])
			{
				SumDi += d[i];
			}
		}
		answer = max(answer, SumDi);
	}
	else
	{
		for (ll i = MaxA; i <= m; i++)
		{
			A[Iteration] = i;
			RecursiveFunction(Iteration + 1, i, A);
		}
	}
	return;
}

int main() {
	vector<ll> A(11, 0);
	cin >> n >> m >> q;
	for (int i = 1; i <= q; i++)
	{
		cin >> a[i] >> b[i] >> c[i] >> d[i];
	}
	for (ll i = 1; i <= m; i++)
	{
		RecursiveFunction(1, i, A);
	}
	cout << answer << endl;
	return 0;
}
