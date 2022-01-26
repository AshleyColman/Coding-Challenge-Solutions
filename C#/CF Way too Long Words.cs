using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word;
        char first;
        char last;
        int between;
        for (int i = 0; i < n; i++)
        {
            word = Console.ReadLine();
            if (word.Length > 10)
            {
                first = word[0];
                last = word[word.Length - 1];
                between = (word.Length - 2);
                Console.WriteLine($"{first}{between}{last}");
            }
            else
            {
                Console.WriteLine(word);
            }
        }
    }
}