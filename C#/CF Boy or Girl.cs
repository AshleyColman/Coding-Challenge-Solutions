using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int distinct = s.Distinct().Count();
        if ((distinct % 2) == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }
    }
}