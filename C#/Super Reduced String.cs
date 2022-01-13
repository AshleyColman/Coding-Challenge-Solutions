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

    // Complete the superReducedString function below.
    static string superReducedString(string s)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(s);

        for (int i = 0; i < sb.Length - 1;)
        {
            if (sb[i] == sb[i + 1])
            {
                sb.Remove(i, 2);
                i = 0;
            }
            else
            {
                i++;
            }
        }

        if (sb.Length == 0)
        {
            return "Empty String";
        }
        else
        {
            return sb.ToString();
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
