#include <iostream>
#include <cstdio>
using namespace std;

int main()
{
    // Complete the code.
    string wordArr[]{"one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                     "ten", "eleven"
                            "twelve"};
    string wordOdd = "odd";
    string wordEven = "even";
    short n1 = 0;
    short n2 = 0;

    cin >> n1 >> n2;

    for (int i = n1; i <= n2; i++)
    {
        if (i <= 9)
        {
            cout << wordArr[i - 1];
        }
        else if (i > 9 && (i % 2) == 0)
        {
            cout << wordEven;
        }
        else
        {
            cout << wordOdd;
        }
        cout << endl;
    }
    return 0;
}
