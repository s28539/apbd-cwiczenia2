﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");
Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

static int GetMaxValue(int[] numbers)
{
    int max2 = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max2 < numbers[i])
        {
            max2 = numbers[i];
        }
    }

    return max2;
}