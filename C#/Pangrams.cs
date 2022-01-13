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

    // Complete the pangrams function below.
    static string pangrams(string s)
    {

        s = s.ToUpper();
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int originalAlphabetLength = alphabet.Length;
        int foundLettersCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (s[i] == alphabet[j])
                {
                    foundLettersCount++;
                    alphabet = alphabet.Remove(j, 1);
                    break;
                }
            }
        }

        if (foundLettersCount == originalAlphabetLength)
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
