using System;

class ReverseStringRecursive
{
    public static string ReverseString(string s)
    {
        if (s.Length <= 1)
            return s;

        string reversedSubstring = ReverseString(s.Substring(1));

        return reversedSubstring + s[0];
    }

   
}
