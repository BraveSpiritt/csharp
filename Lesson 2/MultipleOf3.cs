int index = 1;
int counter = 0;
while (index < 101)
{
    if (index % 3 == 0)
    {

        counter += index;
    }
    index++;
}

Console.WriteLine(counter);