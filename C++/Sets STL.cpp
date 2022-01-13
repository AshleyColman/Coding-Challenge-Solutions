#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <set>
#include <algorithm>
using namespace std;

int main()
{
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int q;
    cin >> q;

    set<int> s;
    set<int>::iterator it;

    for (int i = 0; i < q; i++)
    {
        int y, x;
        cin >> y >> x;
        it = s.find(x);
        switch (y)
        {
        case 1:
            s.insert(x);
            break;
        case 2:
            if (it != s.end())
            {
                s.erase(x);
            }
            break;
        case 3:
            if (it != s.end())
            {
                cout << "Yes" << endl;
            }
            else
            {
                cout << "No" << endl;
            }
            break;
        }
    }
    return 0;
}
