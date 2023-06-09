﻿using System;

public class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide.ToString()))
            {
                return false;
            }
        }

        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";

        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }

        return result;
    }

    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            bool check;
            string output;

            check = IsValidSequence(input);

            if (check == true)
            {
                Console.WriteLine("Current half DNA sequence: " + input);
                Console.WriteLine("Do you want to replicate it? (Y/N):");
                string str = Console.ReadLine();

                while (str != "Y" && str != "N")
                {
                    Console.WriteLine("Please input Y or N.");
                    str = Console.ReadLine();
                }

                if (str == "Y")
                {
                    output = ReplicateSequence(input);
                    Console.WriteLine("Replicated half DNA sequence: " + output);
                }
                else if (str == "N")
                {
                    // Do nothing
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.WriteLine("Do you want to process another sequence? (Y/N):");
            string str2 = Console.ReadLine();

            while (str2 != "Y" && str2 != "N")
            {
                Console.WriteLine("Please input Y or N.");
                str2 = Console.ReadLine();
            }

            if (str2 == "N")
            {
                break;
            }
        }
    }
}
