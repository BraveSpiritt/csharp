using System;

class TaskOne
{
static void DaysInMonth(int month, int year)
    {
        if(year % 4 == 0 && month == 2)
        {
            Console.WriteLine(29);
            return;
        }
        if(month % 2 == 0 && month < 7)
        {
            if(month == 2)
            {
                Console.WriteLine(28); ;
            }
            else
            {
                Console.WriteLine(30); 
            }
        } else if (month % 2 == 0 && month > 7)
        {
            Console.WriteLine(31);
        } else if(month <= 7)
        {
            Console.WriteLine(31); 
        } else 
        {
            Console.WriteLine(30);
        }
    }

    static void Main(string[] args)
    {
        DaysInMonth(2, 2016);
    }

}