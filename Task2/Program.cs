﻿/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int InputData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());    
}

int SumNumbers (int M, int N)
{
    if (M == N)
    {
        return 0;
    }
    
}