#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str)
{
    // Complete this function
    stringstream ss(str);
    int input;
    char skip;
    vector<int> result;
    while (ss)
    {
        if (ss.peek() != ',')
        {
            if (ss >> input)
            {
                result.push_back(input);
            }
        }
        else
        {
            ss >> skip;
        }
    }
    return result;
}

int main()
{
    string str;
    cin >> str;
    vector<int> integers = parseInts(str);
    for (int i = 0; i < integers.size(); i++)
    {
        cout << integers[i] << "\n";
    }

    return 0;
}
