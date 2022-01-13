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

    // Complete the funnyString function below.
    static string funnyString(string s)
    {

        // Reverse string
        char[] sArray = s.ToCharArray();
        char[] rArray = s.ToCharArray();
        Array.Reverse(rArray, 0, rArray.Length);
        string sReverse = new string(rArray);
        // Convert the string into a byte[].
        byte[] normalBytes = Encoding.ASCII.GetBytes(sArray);
        byte[] reverseBytes = Encoding.ASCII.GetBytes(sReverse);

        // Absolute differences
        List<int> normalAbs = new List<int>();
        List<int> reverseAbs = new List<int>();

        for (int i = 0; i < normalBytes.Length - 1; i++)
        {
            normalAbs.Add(Math.Abs(Math.Abs(normalBytes[i]) -
            Math.Abs(normalBytes[i + 1])));

            reverseAbs.Add(Math.Abs(Math.Abs(reverseBytes[i]) -
            Math.Abs(reverseBytes[i + 1])));
        }

        int totalSame = 0;

        for (int i = 0; i < normalAbs.Count; i++)
        {
            if (normalAbs[i] == reverseAbs[i])
            {
                totalSame++;
            }
            else
            {
                break;
            }
        }

        if (totalSame == normalAbs.Count)
        {
            return "Funny";
        }
        else
        {
            return "Not Funny";
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
