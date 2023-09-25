using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string ifade girin: ");
        string input = Console.ReadLine();

        bool[] results = CheckConsecutiveSilentLetters(input);

        Console.WriteLine("Output:");

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    static bool[] CheckConsecutiveSilentLetters(string input)
    {
        bool[] results = new bool[input.Length];

        for (int i = 0; i < input.Length - 1; i++)
        {
            char currentChar = char.ToLower(input[i]);
            char nextChar = char.ToLower(input[i + 1]);

            if (IsSilentLetter(currentChar) && IsSilentLetter(nextChar))
            {
                results[i] = true;
            }
            else
            {
                results[i] = false;
            }
        }

        // Set the last result to false since there is no character after the last one to compare.
        results[input.Length - 1] = false;

        return results;
    }

    static bool IsSilentLetter(char c)
    {
        char[] silentLetters = { 'b', 'c', 'd', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        return Array.Exists(silentLetters, letter => letter == c);
    }
}
