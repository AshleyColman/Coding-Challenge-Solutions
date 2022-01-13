#include <iostream>
#include <string>
using namespace std;

int main()
{
    // Complete the program
    string a, b;
    cin >> a >> b;
    cout << a.size() << " " << b.size() << endl;
    cout << a + b << endl;

    char firstA = a[0];
    char firstB = b[0];
    a[0] = firstB;
    b[0] = firstA;
    cout << a << " " << b;
    return 0;
}
