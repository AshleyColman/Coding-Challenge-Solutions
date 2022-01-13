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

    // Complete the minimumNumber function below.
    static int minimumNumber(string password)
    {
        string numbers = "0123456789";
        string lowerCases = "abcdefghijklmnopqrstuvwxyz";
        string upperCases = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialCharacters = "!@#$%^&*()-+";

        char[] numberArray = numbers.ToCharArray();
        char[] lowerCaseArray = lowerCases.ToCharArray();
        char[] upperCaseArray = upperCases.ToCharArray();
        char[] specialCharacterArray = specialCharacters.ToCharArray();

        int letterCountRequired = 0;

        if (password.IndexOfAny(numberArray) == -1)
        {
            letterCountRequired++;
        }

        if (password.IndexOfAny(lowerCaseArray) == -1)
        {
            letterCountRequired++;
        }

        if (password.IndexOfAny(upperCaseArray) == -1)
        {
            letterCountRequired++;
        }

        if (password.IndexOfAny(specialCharacterArray) == -1)
        {
            letterCountRequired++;
        }

        if (letterCountRequired > (6 - password.Length))
        {
            return letterCountRequired;
        }
        else
        {
            return (6 - password.Length);
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
