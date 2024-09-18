using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {




        Console.Write("Skriv ett ord jag kan jämnföra : ");
        string words1 = Console.ReadLine();
        Console.Write("Skriv ett ord till : ");
        string words2 = Console.ReadLine();

        if (AreAnagrams(words1, words2))
        {
            Console.WriteLine($"\"{words1}\" och \"{words2}\" är anagram.\"");

        }else
        {
            Console.WriteLine($"\"{words1}\" och \"{words2}\" är inte anagram.\"");
        }

    }

    static bool AreAnagrams(string words1, string words2)
    {
        words1 = words1.Replace(" ", "").ToLower();
        words2 = words2.Replace(" ", "").ToLower();


        if (words1.Length != words2.Length)
        {
            return false;
        }

        char[] charArray1 = words1.ToCharArray();
        char[] charArray2 = words2.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return new string(charArray1) == new string(charArray2);
    }


}