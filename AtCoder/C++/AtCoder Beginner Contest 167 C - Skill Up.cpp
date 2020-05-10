//AtCoder Beginner Contest 167
//C - Skill Up
#include "bits/stdc++.h"
using namespace std;
typedef long long ll;
ll n, m, x, answer = LLONG_MAX, c[13] = {}, a[13][13] = {};
void BuyBook(ll buyBookNumber, ll paidYen, vector<ll> understandingSums)
{
	paidYen += c[buyBookNumber];
	for (ll i = 1; i <= m; i++)
	{
		understandingSums[i] += a[buyBookNumber][i];
	}
	for (ll i = 1; i <= m; i++)
	{
		if (understandingSums[i] < x)
		{
			break;
		}
		if (i == m)
		{
			answer = min(answer, paidYen);
			return;
		}
	}
	for (ll i = buyBookNumber + 1; i <= n; i++)
	{
		if (i <= n)
		{
			BuyBook(i, paidYen, understandingSums);
		}
	}
	return;
}
int main() {
	cin >> n >> m >> x;
	for (int i = 1; i <= n; i++)
	{
		cin >> c[i];
		for (int j = 1; j <= m; j++)
		{
			cin >> a[i][j];
		}
	}
	for (ll i = 1; i <= m; i++)
	{
		ll understandingSum = 0;
		for (ll j = 1; j <= n; j++)
		{
			understandingSum += a[j][i];
		}
		if (understandingSum < x)
		{
			cout << -1 << endl;
			return 0;
		}
	}
	for (ll i = 1; i <= n; i++)
	{
		vector<ll> tmpUnderstandingSum(13, 0);
		BuyBook(i, 0, tmpUnderstandingSum);
	}
	cout << answer << endl;
	return 0;
}
