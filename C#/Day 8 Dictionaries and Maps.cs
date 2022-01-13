using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Dictionary<string, int> phoneDictionary = new Dictionary<string, int>();
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            string name = values[0];
            int number = Convert.ToInt32(values[1]);
            phoneDictionary.Add(name, number);
        }

        string input;
        while ((input = Console.ReadLine()) != null)
        {
            if (phoneDictionary.ContainsKey(input))
            {
                Console.WriteLine(input + "=" + phoneDictionary[input]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
