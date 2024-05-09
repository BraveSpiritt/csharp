using System;

public class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        return BinarySearchRecursive(arr, target, 0, arr.Length - 1);
    }

    private static int BinarySearchRecursive(int[] arr, int target, int low, int high)
    {
        if (low > high)
            return -1; 
        int mid = low + (high - low) / 2;

        if (arr[mid] == target)
            return mid; 

        if (arr[mid] < target)
            return BinarySearchRecursive(arr, target, mid + 1, high); 
        else
            return BinarySearchRecursive(arr, target, low, mid - 1); 
    }
}


