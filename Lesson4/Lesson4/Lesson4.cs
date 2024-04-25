using System;

public class Program

{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, -1, -6 };
        int biggestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > biggestNumber)
            {
                biggestNumber = number;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}



/*public class Program
{
    public static void Main(string[] args)
    {
        string str = "HelleH";
        int len = str.Length;
        bool isPalindrome = true;

        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        Console.WriteLine(isPalindrome ? "The string is a palindrome." : "No, it's not a palindrome. Gotcha non-palindrome!");
    }
}*/

/*public class Program
{
    public static void Main(string[] args)
    {
        int[] a1 = { 1, 5, 10, 8 };
        int[] a2 = { 6, 8, 17, 4, 1 };

        for (int i = 0; i < a1.Length; i++)
        {
            for (int j = 0; j < a2.Length; j++)
            {
                if (a1[i] == a2[j])
                {
                    Console.WriteLine(a1[]);
                }
            }
        }

    }
}*/
/*public class Program
{
    static int CountWords(string text)
    {
        // Split the string into words based on whitespace characters
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Return the number of words
        return words.Length;
    }

    static void Main(string[] args)
    {
        string text = "It works on my machine";
        int wordCount = CountWords(text);
        Console.WriteLine("Number of words: " + wordCount);
    }
}*/

/*public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int res = 0;
        int temp = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                res = Math.Max(res, temp);
                temp = 0;
            }
            else temp++;
        }

        return Math.Max(res, temp);
    }
}*/