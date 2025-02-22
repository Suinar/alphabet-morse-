using System;
using System.Linq;
using System.Collections.Generic;

public class program
{
    public static void Main()
    {
        string WordsOutPut = "";
        Dictionary<char, string> Alphabet = new Dictionary<char, string>
        {
            { 'A', ".- " },
            { 'B', "-... " },
            { 'C', "-.-. " },
            { 'D', "-.. " },
            { 'E', ". " },
            { 'F', "..-. " },
            { 'G', "--. " },
            { 'H', ".... " },
            { 'I', ".. " },
            { 'J', ".--- " },
            { 'K', "-.- " },
            { 'L', ".-.. " },
            { 'M', "-- " },
            { 'N', "-. " },
            { 'O', "--- " },
            { 'P', ".--. " },
            { 'Q', "--.- " },
            { 'R', ".-. " },
            { 'S', "... " },
            { 'T', "- " },
            { 'U', "..- " },
            { 'V', "...- " },
            { 'W', ".-- " },
            { 'X', "-..- " },
            { 'Y', "-.-- " },
            { 'Z', "--.. " },

            { '1', ".---- " },
            { '2', "..--- " },
            { '3', "...-- " },
            { '4', "....- " },
            { '5', "..... " },
            { '6', "-.... " },
            { '7', "--... " },
            { '8', "---.. " },
            { '9', "----. " },
            { '0', "----- " }
        };

        Console.WriteLine("Write what you want to encrypt ");
        string WordsToEncrypt = Console.ReadLine();

        WordsToEncrypt = new string(WordsToEncrypt.Where(c => !char.IsWhiteSpace(c)).ToArray());
        char[] CharWordsToEncrypt = WordsToEncrypt.ToCharArray();
        CharWordsToEncrypt = CharWordsToEncrypt.Select(char.ToUpper).ToArray();

        foreach (char letter in CharWordsToEncrypt)
        {
            if (Alphabet.TryGetValue(letter, out string MorseCod))
            {
                WordsOutPut += MorseCod;
            }
        }
        Console.WriteLine($"In alphabet morsa it`s: {WordsOutPut}");
    }
}