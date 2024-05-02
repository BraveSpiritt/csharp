using System;
using System.Collections.Generic;


public class LessonSix
{
    public List<int> RemoveOddNumber(List<int> list)
    {
        return list.Where(i => i % 2 == 0).ToList();
    }
    public static void Main(string[] args)
    {
        int[] numberCollection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<int> numbers = new List<int>(numberCollection);
        LessonSix lesson = new LessonSix();
        List<int> evenNumbers = lesson.RemoveOddNumber(numbers);

        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }


    }
}