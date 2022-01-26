using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int upper = 0;
        int lower = 0;
        foreach (char c in s)
        {
            if (char.IsUpper(c) == true)
            {
                upper++;
            }
            else
            {
                lower++;
            }
        }
        if (upper == lower)
        {
            s = s.ToLower();
        }
        else if (upper > lower)
        {
            s = s.ToUpper();
        }
        else if (upper < lower)
        {
            s = s.ToLower();
        }
        Console.WriteLine(s);
    }
}