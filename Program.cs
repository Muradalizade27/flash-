﻿#region edeedlerin ust uste gelmeyi
static int number(int num)
{
    while (num > 0)
    {
        int x = num % 10;
        x += x;
        Console.WriteLine(x);
        return x;


    }
    return num;
}
int num = number(254);

#endregion




#region  metod yolu
Console.WriteLine("eded daxil edin");

string numStr = Console.ReadLine();

int _ = Convert.ToInt32(numStr);

Console.WriteLine("cavab");

number(num);

static void numb(int num)
{
    if (num % 7 == 0)
    {
        Console.WriteLine("7-e bolunur");

    }

    else
    {
        for (int i = 1; i < 7; i++)
        {
            if ((num - i) % 7 == 0)
            {
                Console.WriteLine(num - i);
                break;
            }
            else if ((num + i) % 7 == 0)
            {
                Console.WriteLine(num + i);
                break;
            }
        }
    }
}
#endregion
