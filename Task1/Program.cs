/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

int temporary = m;
if (temporary > n) 
{
    m = n;
    n = temporary;
}    

//PrintSumm(m, n);

void PrintSumm(int m, int n)
{  
  if (n == m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
