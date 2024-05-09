using System;
using System.Collections.Generic;

public class DigitExtractor
{
    public static List<int> ExtractDigits(int n)
    {
        List<int> digits = new List<int>();

        string numberString = n.ToString();

        foreach (char c in numberString)
        {
            digits.Add(int.Parse(c.ToString()));
        }

        return digits;
    }
}
