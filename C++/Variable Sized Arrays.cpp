#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */

    int n;
    int q;
    cin >> n;
    cin >> q;

    vector<int> a[n];
    for (int i = 0; i < n; i++)
    {
        vector<int> v;
        int k;
        cin >> k;
        for (int j = 0; j < k; j++)
        {
            int val;
            cin >> val;
            v.push_back(val);
        }
        a[i] = v;
    }

    for (int i = 0; i < q; i++)
    {
        int aIndex;
        cin >> aIndex;
        int jIndex;
        cin >> jIndex;
        cout << a[aIndex][jIndex] << endl;
    }
    return 0;
}
