using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        if (char.IsUpper(s[0]))
        {
            Console.WriteLine(s);
            return;
        }

        string first = s[0].ToString();
        first = first.ToUpper();
        string last = s.Substring(1, s.Length - 1);
        Console.WriteLine($"{first}{last}");
    }
}