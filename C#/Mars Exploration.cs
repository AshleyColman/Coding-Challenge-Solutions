using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the marsExploration function below.
    static int marsExploration(string s)
    {

        char[] stringCompare = new char[3] { 'S', 'O', 'S' };
        int compareIndex = 0;
        int totalChanged = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // Check every 3 letters
            // Check order for S, O, S
            // If letter is wrong increment letters wrong
            // Reset and check next 3

            if (i % 3 == 0)
            {
                // At start
                compareIndex = 0;
            }
            else
            {
                compareIndex++;
            }

            if (s[i] != stringCompare[compareIndex])
            {
                totalChanged++;
            }
        }

        return totalChanged;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
