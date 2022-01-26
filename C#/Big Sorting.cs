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
using System.Numerics;

class Result
{

    /*
     * Complete the 'bigSorting' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY unsorted as parameter.
     */

    public static List<string> bigSorting(List<string> unsorted)
    {
        List<BigInteger> unsortedIntList = new List<BigInteger>();
        for (int i = 0; i < unsorted.Count; i++)
        {
            unsortedIntList.Add(BigInteger.Parse(unsorted[i]));
        }

        for (int i = 1; i < unsortedIntList.Count; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (unsortedIntList[j] < unsortedIntList[j - 1])
                {
                    string current = unsorted[j];
                    unsorted[j] = unsorted[j - 1];
                    unsorted[j - 1] = current;

                    BigInteger currentInt = unsortedIntList[j];
                    unsortedIntList[j] = unsortedIntList[j - 1];
                    unsortedIntList[j - 1] = currentInt;
                }
            }
        }
        return unsorted;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> unsorted = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string unsortedItem = Console.ReadLine();
            unsorted.Add(unsortedItem);
        }

        List<string> result = Result.bigSorting(unsorted);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
