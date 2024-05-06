using System;
using System.Diagnostics.CodeAnalysis;

class Fibonacci
{
    public int CalculateFibonacci(int endingPoint) {
        if(endingPoint <= 1)
        {
            return endingPoint;
        }
        return CalculateFibonacci(endingPoint - 1) + CalculateFibonacci(endingPoint - 2);
    }

    public static void Main(string[] args)
    {
        int sum = new BeerAndBottles().CalculateAmountOfBeers(10);
        Console.WriteLine(sum);
    }

}