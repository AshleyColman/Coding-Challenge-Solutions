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
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        float iTotalPositive = 0;
        float iTotalNegative = 0;
        float iTotalZero = 0;

        float fPositiveFraction = 0;
        float fNegativeFraction = 0;
        float fZeroFraction = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                iTotalPositive += 1;
            }

            if (arr[i] == 0)
            {
                iTotalZero += 1;
            }

            if (arr[i] < 0)
            {
                iTotalNegative += 1;
            }
        }

        // Calculate fraction
        fPositiveFraction = iTotalPositive / arr.Length;
        fNegativeFraction = iTotalNegative / arr.Length;
        fZeroFraction = iTotalZero / arr.Length;

        Console.WriteLine(fPositiveFraction + Environment.NewLine + fNegativeFraction +
       Environment.NewLine + fZeroFraction);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
