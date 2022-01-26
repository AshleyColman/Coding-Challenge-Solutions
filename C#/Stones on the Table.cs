using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int count = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                s = s.Remove(i, 1);
                count++;
                i = 0;
            }
        }
        Console.WriteLine(count);
    }
}