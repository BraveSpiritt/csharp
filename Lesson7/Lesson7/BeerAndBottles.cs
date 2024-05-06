using System;

class BeerAndBottles
{
    public int CalculateAmountOfBeers(int money, int emptyBottles = 0)
    {
        if (money < 3 && emptyBottles < 3)
        {
            return 0;
        }


        int beersBought = money / 3;
        int remainingMoney = money % 3;


        int beersFromReturnedBottles = emptyBottles / 3;
        int remainingEmptyBottles = (emptyBottles % 3) + beersBought;

        return beersBought + beersFromReturnedBottles + CalculateAmountOfBeers(remainingMoney, remainingEmptyBottles);
    }
}
