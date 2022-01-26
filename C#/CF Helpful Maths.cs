using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] sArr = s.Split('+');
        Array.Sort(sArr);
        List<string> sList = new List<string>();

        string plus = "+";
        for (int i = 0; i < sArr.Length; i++)
        {
            sList.Add(sArr[i]);
            if (i < (sArr.Length - 1))
            {
                sList.Add(plus);
            }
        }
        sList.ForEach(s => Console.Write(s));
    }
}