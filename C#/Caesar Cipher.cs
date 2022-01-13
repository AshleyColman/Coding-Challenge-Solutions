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

    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k)
    {

        char[] alphabetArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
        'k', 'l', 'm', 'n', 'o', 'p','q', 'r', 's', 't', 'u', 'v', 'w', 'x',
        'y', 'z' };

        string cipherString = string.Empty;
        int cipherIndex = 0;
        char cipherChar = '-';

        var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsLetter(s[i]))
            {
                int charIndex = Array.IndexOf(alphabetArray, Char.ToLower(s[i]));
                charIndex += k;

                if (charIndex >= alphabetArray.Length)
                {
                    cipherIndex = charIndex - alphabetArray.Length;

                    while (cipherIndex >= alphabetArray.Length)
                    {
                        // Find out how much is over alphabetArray.Length
                        cipherIndex = cipherIndex - alphabetArray.Length;
                    }

                    cipherChar = alphabetArray[cipherIndex];
                }
                else
                {
                    cipherChar = alphabetArray[charIndex];
                }

                if (Char.IsUpper(s[i]))
                {
                    cipherString += Char.ToUpper(cipherChar);
                }
                else
                {
                    cipherString += cipherChar;
                }
            }
            else
            {
                cipherChar = s[i];
                cipherString += cipherChar;
            }
        }

        return cipherString;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
