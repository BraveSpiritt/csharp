using System;

class Program
{
    static int MaxElement(int[] arr, int n)
    {
        if (n == 1)
            return arr[0];

        int maxRest = MaxElement(arr, n - 1);

        return Math.Max(maxRest, arr[n - 1]);
    }

    static void Main(string[] args)
    {
        //find max number of array
        //int[] arr = { 3, 7, 2, 9, 5 };
        //Console.WriteLine("Max element: " + MaxElement(arr, arr.Length));

        //Reverse string
        //string originalString = "Hello, world!";
        //Console.WriteLine("Original string: " + originalString)
        //string reversedString = ReverseStringRecursive.ReverseString(originalString);
        //Console.WriteLine("Reversed string: " + reversedString);

        //Find an element in a sorted array using binary search
        // int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        //int target = 14;
        //int index = BinarySearch.Search(arr, target);
        //if (index != -1)
        //Console.WriteLine("Element " + target + " found at index " + index);
        //else
        //Console.WriteLine("Element " + target + " not found in the array.");

        int n = 1324659871;
        List<int> digits = DigitExtractor.ExtractDigits(n);

        Console.WriteLine("Digits of " + n + ": [" + string.Join(", ", digits) + "]");
    }
}
