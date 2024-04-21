//double sum = 0;
//double denom = 1;

//for (int i = 0; i < 500000; i++)
//{
//    sum += 1 / (denom * (denom + 2));
//    denom += 4;
//}

//Console.WriteLine(sum * 8);

//int n = 70;

//for (int i = 0; i < n / 2 + 1; i++)
//{
//    Console.Write(new string(' ', n / 2 - i));
//    Console.WriteLine(new string('*', i * 2 + 1));
//}

//for (int i = 0; i < 3; i++)
//{
//    Console.Write(new string(' ', n / 2));
//    Console.WriteLine('*');
//}

int timeout = 200;
string str = " ";
Console.CursorVisible = false;
Console.BackgroundColor = ConsoleColor.White;


for (int i = 0; i < 20; i++)
{
    Thread.Sleep(timeout);
    Console.Write(str + i + 5 * 5 + "%");

}
Console.BackgroundColor = ConsoleColor.Black;
