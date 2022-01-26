using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        int result = string.Compare(word1, word2, true);
        Console.WriteLine(result);
    }
}